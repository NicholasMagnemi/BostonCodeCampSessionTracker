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
using BostonCodeCampSessionTracker.Validation;
using FluentValidation;

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
                //SpeakerBio = speakerBio;
                //SpeakerPastTalks = speakerPastTalks;
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

        public bool addRoom(int maxOccupancy, String roomName)
        {
            RoomValidator validator = new RoomValidator();

            using CodeCampAppContext context = new CodeCampAppContext();

            Room newRoom = new Room()
            {
                RoomMaxOcc = maxOccupancy,
                RoomName = roomName
            };

            ValidationResult results = validator.Validate(newRoom);

            if (results.IsValid == false)
            {
                return false;
            }
            else
            {
                context.Rooms.Add(newRoom);
                context.SaveChanges();
                return true;
            }


        }

        public bool addSession(String sessionTitle, int roomId, int SpeakerId, int timeId)
        {
            SessionValidator validator = new SessionValidator();

            using CodeCampAppContext context = new CodeCampAppContext();

            Session newSession = new Session()
            {
                SessionTitle = sessionTitle,
                RoomId = roomId,
                SpeakerId = SpeakerId,
                TimeId = timeId,
            };

            ValidationResult results = validator.Validate(newSession);

            if (results.IsValid == false)
            {
                return false;
            }
            else
            {
                context.Sessions.Add(newSession);
                context.SaveChanges();
                return true;
            }


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

        public bool addTimeSlot(TimeSpan timeBegin, TimeSpan timeEnd, decimal timeDuration)
        {
            TimeSlotValidator validator = new TimeSlotValidator();

            using CodeCampAppContext context = new CodeCampAppContext();

            TimeSlot newTimeSlot = new TimeSlot()
            {
                TimeBegin = timeBegin,
                TimeEnd = timeEnd,
                TimeDuration = timeDuration
            };

            ValidationResult results = validator.Validate(newTimeSlot);

            if (results.IsValid == false)
            {
                return false;
            }
            else
            {
                context.TimeSlots.Add(newTimeSlot);
                context.SaveChanges();
                return true;
            }

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

        public List<String> retrieveRoomNames() 
        {
            using CodeCampAppContext context = new CodeCampAppContext();

            List<string> roomNames = new List<string>();

            var rooms = context.Rooms.ToList();

            foreach (var room in rooms)
            {
                roomNames.Add(room.RoomName);
            }
            return roomNames;
        }

        public List<String> retrieveStartingTimeSlots()
        {
            using CodeCampAppContext context = new CodeCampAppContext();

            List<string> timeSlots = new List<string>();

            var times = context.TimeSlots.ToList();

            foreach (var time in times)
            {
                timeSlots.Add(time.TimeBegin.ToString());
            }
            return timeSlots;
        }

        public List<String> retrieveEndingTimeSlots()
        {
            using CodeCampAppContext context = new CodeCampAppContext();

            List<string> timeSlots = new List<string>();

            var times = context.TimeSlots.ToList();

            foreach (var time in times)
            {
                timeSlots.Add(time.TimeEnd.ToString());
            }
            return timeSlots;


        }
    }
}
