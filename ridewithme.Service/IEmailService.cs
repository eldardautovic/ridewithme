namespace ridewithme.Services
{
    public interface IEmailService
    {
        public void SendingMessage(string message);
        public void SendingObject<T>(T obj);
    }
}