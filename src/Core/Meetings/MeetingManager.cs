namespace Meetings.Meetings;

public class MeetingManager
{
    public Task AddAttendee(AddMeetingAttendee command)
    {
        // Logic to add an attendee to a meeting
        // This is a placeholder for the actual implementation
        Console.WriteLine($"Adding {command.GuestsNumber} attendees to meeting {command.MeetingId}");
        return Task.CompletedTask;
    }
}
