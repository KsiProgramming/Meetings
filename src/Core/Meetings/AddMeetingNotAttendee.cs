namespace Meetings.Meetings;

public class AddMeetingNotAttendee
{
    public Guid MeetingId { get; }

    public AddMeetingNotAttendee(Guid meetingId)
    {
        MeetingId = meetingId;
    }
}
