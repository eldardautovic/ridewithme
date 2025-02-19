namespace ridewithme.Service.Interfaces
{
    public interface IEmailService
    {
        public void SendingMessage(string message);
        public void SendingObject<T>(T obj);
    }
}