namespace Meetings.Meetings;

internal class GetMeetingDetails
{
    public GetMeetingDetails(Guid meetingId)
    {
        MeetingId = meetingId;
    }

    public Guid MeetingId { get; }
}
