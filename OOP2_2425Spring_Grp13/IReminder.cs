
public interface IReminder
{
    int Id { get; set; }
    DateTime ReminderDateTime { get; set; }
    string Summary { get; set; }
    string Description { get; set; }

    void Notify();
}
