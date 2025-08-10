namespace Meetings.Meetings;

public class GetMeetingAttendee
{
    public GetMeetingAttendee(Guid meetingId)
    {
        MeetingId = meetingId;
    }

    public Guid MeetingId { get; }
}
