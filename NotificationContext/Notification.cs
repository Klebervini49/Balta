namespace Balta.NotificationContext
{

    public sealed class Notification
    {
        public Notification()
        {

        }

        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public String Property { get; set; }
        public String Message { get; set; }
    }

}