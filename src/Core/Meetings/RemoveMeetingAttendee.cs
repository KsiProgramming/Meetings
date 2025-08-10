namespace Meetings.Meetings;

public class RemoveMeetingAttendee
{
    public RemoveMeetingAttendee(Guid meetingId, Guid attendeeId, string removingReason)
    {
        MeetingId = meetingId;
        AttendeeId = attendeeId;
        RemovingReason = removingReason;
    }

    public Guid MeetingId { get; }

    public Guid AttendeeId { get; }

    public string RemovingReason { get; }
}
