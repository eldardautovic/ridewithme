using EasyNetQ;
using ridewithme.Model;
using MailingService;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using ridewithme.Model.Messages;
using System.Net.Mail;


public class ConsumeRabbitMQHostedService : BackgroundService
{
    private readonly ILogger _logger;
    private IConnection _connection;
    private IModel _channel;
    private readonly IEmailSender _emailSender;

    private readonly string _host = Environment.GetEnvironmentVariable("RABBITMQ_HOST") ?? "localhost";
    private readonly string _username = Environment.GetEnvironmentVariable("RABBITMQ_USERNAME") ?? "guest";
    private readonly string _password = Environment.GetEnvironmentVariable("RABBITMQ_PASSWORD") ?? "guest";
    private readonly string _virtualhost = Environment.GetEnvironmentVariable("RABBITMQ_VIRTUALHOST") ?? "/";

    public ConsumeRabbitMQHostedService(ILoggerFactory loggerFactory, IEmailSender emailSender)
    {
        _logger = loggerFactory.CreateLogger<ConsumeRabbitMQHostedService>();
        _emailSender = emailSender;
        InitRabbitMQ();
    }

    private void InitRabbitMQ()
    {
        var factory = new ConnectionFactory
        {
            HostName = _host,
            UserName = _username,
            Password = _password
        };


        _connection = factory.CreateConnection();


        _channel = _connection.CreateModel();


        _channel.QueueDeclare("Reservation_added", false, false, false, null);

        _channel.BasicQos(0, 1, false);

        _connection.ConnectionShutdown += RabbitMQ_ConnectionShutdown;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using (var bus = RabbitHutch.CreateBus($"host={_host};virtualHost={_virtualhost};username={_username};password={_password}"))
                {
                    bus.PubSub.Subscribe<VoznjeActivated>("activated_rides", HandleMessage);
                    Console.WriteLine("Čekanje na mailove");
                    await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
                }


            }
            catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
            {

                break;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error in RabbitMQ listener: {ex.Message}");
            }
        }
    }

    private async Task HandleMessage(VoznjeActivated mail)
    {

        await _emailSender.SendEmailAsync(mail.email, "Vaša vožnja je aktivirana",
                $@"
                <div style='font-family: Arial, sans-serif; color: #333; line-height: 1.6;'>
                    <h2 style='color: #39D5C3;'>Poštovani <b>{mail.Voznja.Vozac.Ime} {mail.Voznja.Vozac.Prezime}</b>,</h2>
                    <p>Uspješno ste aktivirali vožnju broj: <b>{mail.Voznja.Id}</b>.</p>
                    <div style='margin: 20px 0; padding: 15px; background-color: #f9f9f9; border-left: 4px solid #39D5C3;'>
                        <h3><strong>Detalji vožnje:</strong></p>
                        <ul style='list-style-type: none; padding-left: 0;'>
                            <li><p><b>Polazak:</b> {mail.Voznja.GradOd.Naziv}</p></li>
                            <li><p><b>Odredište:</b> {mail.Voznja.GradDo.Naziv}</p></li>
                            <li><p><b>Cijena vožnje:</b> {mail.Voznja.Cijena} KM</p></li>
                        </ul>
                    </div>
                    <p style='margin-top: 20px;'>Ukoliko je ovo greška, molimo Vas da podnesete žalbu.</p>
                    <p style='margin-top: 20px;'><i>Hvala što koristite našu uslugu!</i></p>
                    <hr style='border: none; border-top: 1px solid #ddd; margin: 20px 0;' />
                    <p style='font-size: 0.9em; color: #555;'>Ova poruka je automatski generisana. Molimo Vas da ne odgovarate na ovu poruku.</p>
                </div>");

    }

    private void OnConsumerConsumerCancelled(object sender, ConsumerEventArgs e) { }
    private void OnConsumerUnregistered(object sender, ConsumerEventArgs e) { }
    private void OnConsumerRegistered(object sender, ConsumerEventArgs e) { }
    private void OnConsumerShutdown(object sender, ShutdownEventArgs e) { }
    private void RabbitMQ_ConnectionShutdown(object sender, ShutdownEventArgs e) { }

    public override void Dispose()
    {
        _channel.Close();
        _connection.Close();
        base.Dispose();
    }
}