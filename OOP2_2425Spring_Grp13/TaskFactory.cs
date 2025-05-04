
public class TaskFactory : IReminderFactory
{
    public IReminder CreateReminder()
    {
        return new TaskReminder();
    }
}
