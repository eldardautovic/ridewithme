// See https://aka.ms/new-console-template for more information
using EasyNetQ;
using ridewithme.Model.Messages;

Console.WriteLine("Hello, World!");

var bus = RabbitHutch.CreateBus("host=localhost");

await bus.PubSub.SubscribeAsync<VoznjeActivated>("console_printer", msg => {
            Console.WriteLine($"Voznja aktivirana: {msg.Voznja.Id}");
    }
);

Console.WriteLine("Listening for messages, press return to close.");

Console.ReadLine();
