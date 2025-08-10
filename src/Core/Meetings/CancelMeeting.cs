namespace Meetings.Meetings;

public class CancelMeeting
{
    public CancelMeeting(Guid meetingId)
    {
        MeetingId = meetingId;
    }

    public Guid MeetingId { get; }
}
