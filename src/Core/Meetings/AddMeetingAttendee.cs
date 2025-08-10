namespace Meetings.Meetings;

public class AddMeetingAttendee
{
    public Guid MeetingId { get; }

    public int GuestsNumber { get; }

    public AddMeetingAttendee(Guid meetingId, int guestsNumber)
    {
        MeetingId = meetingId;
        GuestsNumber = guestsNumber;
    }
}
