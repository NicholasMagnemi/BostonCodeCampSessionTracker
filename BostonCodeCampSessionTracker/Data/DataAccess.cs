using SemesterProjectTest.Data;
using SemesterProjectTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

//  using CodeCampAppContext context = new CodeCampAppContext();

namespace SemesterProjectTest.Data
{
    public class DataAccess
    {

        public void addSpeaker(String fName, String lName, String eMail, String dayOfContact)
        {
            using CodeCampAppContext context = new CodeCampAppContext();



            Speaker newSpeaker = new Speaker()
            {
                SpeakerFname = fName,
                SpeakerLname = lName,
                SpeakerEmail = eMail,
                SpeakerDayOfContact = dayOfContact

            };
            context.Speakers.Add(newSpeaker);
            context.SaveChanges();
        }

        public void addRoom(int maxOccupancy, String roomName)
        {
            using CodeCampAppContext context = new CodeCampAppContext();

            Room newRoom = new Room()
            {
                RoomMaxOcc = maxOccupancy,
                RoomName = roomName
            };
        }

        public void addSession(String sessionTitle, int roomId, int SpeakerId, int timeId)
        {
            using CodeCampAppContext context = new CodeCampAppContext();

            Session newSession = new Session()
            {
                SessionTitle = sessionTitle,
                RoomId = roomId,
                SpeakerId = SpeakerId,
                TimeId = timeId,
            };
        }

        public void addSessionSpeaker(int speakerId, int sessionId)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            SessionSpeaker newSessionSpeaker = new SessionSpeaker()
            {
                SpeakerId = speakerId,
                SessionId = sessionId,
            };
        }

        public void addTimeSlot(TimeSpan timeBegin, TimeSpan timeEnd, decimal timeDuration)
        {
            using CodeCampAppContext context = new CodeCampAppContext();

            TimeSlot newTimeSlot = new TimeSlot()
            {
                TimeBegin = timeBegin,
                TimeEnd = timeEnd,
                TimeDuration = timeDuration
            };
        }

    }
}
