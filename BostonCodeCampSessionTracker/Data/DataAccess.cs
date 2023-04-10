using BostonCodeCampSessionTracker.Models;
using BostonCodeCampSessionTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using BostonCodeCampSessionTracker.Validations;
using FluentValidation.Results;

//  using CodeCampAppContext context = new CodeCampAppContext();

namespace BostonCodeCampSessionTracker.Data
{
    public class DataAccess
    {

        public bool addSpeaker(String fName, String lName, String eMail, String speakerPhone, String dayOfContact)
        {
            SpeakerValidator validator = new SpeakerValidator();

            using CodeCampAppContext context = new CodeCampAppContext();

            Speaker newSpeaker = new Speaker()
            {
                SpeakerFname = fName,
                SpeakerLname = lName,
                SpeakerEmail = eMail,
                SpeakerPhone = speakerPhone,
                SpeakerDayOfContact = dayOfContact
            };

            ValidationResult results = validator.Validate(newSpeaker);
            if (results.IsValid == false) 
            {
                return false;
            }
            else
            {
                context.Speakers.Add(newSpeaker);
                context.SaveChanges();
                return true;
            }
            
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

        public List<String> retrieveSpeakerNames()
        {
            using CodeCampAppContext context = new CodeCampAppContext();

            List<string> speakersFullNames = new List<string>();

            var speakers = context.Speakers.ToList();

            foreach ( var speaker in speakers ) 
            {
                speakersFullNames.Add(speaker.SpeakerFname + " " + speaker.SpeakerLname);
            }
            return speakersFullNames;
        }
    }
}
