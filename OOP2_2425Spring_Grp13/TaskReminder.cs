
public class TaskReminder : IReminder
{
    public int Id { get; set; }
    public DateTime ReminderDateTime { get; set; }
    public string Summary { get; set; }
    public string Description { get; set; }

    public void Notify()
    {
        Console.WriteLine("Task Reminder: " + Summary);
    }
}
