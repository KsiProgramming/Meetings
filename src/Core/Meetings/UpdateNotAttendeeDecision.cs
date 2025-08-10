namespace Meetings.Meetings;

public class UpdateNotAttendeeDecision
{
    public UpdateNotAttendeeDecision(Guid meetingId)
    {
        MeetingId = meetingId;
    }

    public Guid MeetingId { get; }
}
