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

    public Task AddNotAttendee(AddMeetingNotAttendee command)
    {
        // Logic to add an attendee to a meeting
        // This is a placeholder for the actual implementation
        Console.WriteLine($"Adding not attendee to meeting {command.MeetingId}");
        return Task.CompletedTask;
    }

    public Task Cancel(CancelMeeting command)
    {
        // Logic to cancel a meeting
        // This is a placeholder for the actual implementation
        Console.WriteLine($"Cancelling meeting {command.MeetingId}");
        return Task.CompletedTask;
    }

    public Task ChangeMainAttributes(ChangeMeetingMainAttributes command)
    {
        // Logic to create a meeting
        // This is a placeholder for the actual implementation
        Console.WriteLine($"Changing main attributes for meeting {command.MeetingId}");
        return Task.CompletedTask;
    }
}
