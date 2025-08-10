namespace Meetings.Meetings;

public class GetMeetingDetails
{
    public GetMeetingDetails(Guid meetingId)
    {
        MeetingId = meetingId;
    }

    public Guid MeetingId { get; }
}
