
public class MeetingFactory : IReminderFactory
{
    public IReminder CreateReminder()
    {
        return new MeetingReminder();
    }
}
