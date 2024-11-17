namespace Logging.DispatchProxy;

public interface INotificationService
{
    void Send(string message);
    void Checkdelivery(int messageId);
}

public class NotificationService : INotificationService
{
    public void Send(string message)
        =>
            Console.WriteLine(message);


    public void Checkdelivery(int messageId)
        =>
            Console.WriteLine("Delivery");
}