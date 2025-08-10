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

    public Task ChangeMainAttributes(UpdateMeetingMainAttributes command)
    {
        // Logic to create a meeting
        // This is a placeholder for the actual implementation
        Console.WriteLine($"Changing main attributes for meeting {command.MeetingId}");
        return Task.CompletedTask;
    }

    public Task UpdateNotAttendeeDecision(UpdateNotAttendeeDecision command)
    {
        // Logic to update not attendee decision
        // This is a placeholder for the actual implementation
        Console.WriteLine($"Updating not attendee decision for meeting {command.MeetingId}");
        return Task.CompletedTask;
    }

    public Task Create(CreateMeeting command)
    {
        // Logic to create a meeting
        // This is a placeholder for the actual implementation
        Console.WriteLine($"Creating meeting with title: {command.Title}");
        return Task.CompletedTask;
    }

    public Task<IReadOnlyList<int>> GetAttendees(GetMeetingAttendee query)
    {
        // Logic to GetAttendees a meeting
        // This is a placeholder for the actual implementation
        Console.WriteLine($"Deleting meeting {query.MeetingId}");
        return Task.FromResult<IReadOnlyList<int>>([]);
    }
}
