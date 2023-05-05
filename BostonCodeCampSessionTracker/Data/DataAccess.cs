using BostonCodeCampSessionTracker.Data;
using BostonCodeCampSessionTracker.Models;
using BostonCodeCampSessionTracker.Validation;
using BostonCodeCampSessionTracker.Validations;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace temp.Data
{
    public class DataAccess
    {
        public DataAccess() { }

        /*public bool addCount(String startingCount, String MiddleCount, String EndingCount, String sessionName)
        {
            CountValidator validator = new CountValidator();

            using CodeCampAppContext context = new CodeCampAppContext();
            {
                Count newCount = new Count()
                {
                    BeginningCount = Convert.ToInt32(startingCount),
                    MiddleCount = Convert.ToInt32(MiddleCount),
                    EndingCount = Convert.ToInt32(EndingCount)
                };

                Session newSession = new Session()
                {
                    CountId = retrieveSessionCountId(sessionName)
                };

                ValidationResult results = validator.Validate(newCount);

                if (results.IsValid == false)
                {
                    String validationFailureMessage = "";

                    foreach (ValidationFailure failure in results.Errors)
                    {
                        validationFailureMessage += failure.ErrorMessage + "\n";
                    }

                    MessageBox.Show(validationFailureMessage);
                    return false;
                }
                else
                {
                    context.Counts.Update(newCount);
                    context.SaveChanges();
                    return true;
                }
            }
        }

        public int createEmptyCountRow()
        {
            CountValidator validator = new CountValidator();

            using CodeCampAppContext context = new CodeCampAppContext();
            {
                Count newCount = new Count()
                {
                    BeginningCount = 0,
                    MiddleCount = 0,
                    EndingCount = 0,
                };

                context.Counts.Add(newCount);
                context.SaveChanges();

                return newCount.CountId;
            }
        }

        public int retrieveSessionCountId(String aSessionsName)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                var sessions = context.Sessions.ToList();

                foreach (var session in sessions)
                {
                    if (session.SessionTitle == aSessionsName)
                    {
                        return session.CountId;
                    }
                }
                return 0;
            }
        }

        public int? retrieveBeginningCountID(int countId)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                var counts = context.Counts.ToList();

                foreach (var count in counts)
                {
                    if (count.CountId == countId)
                    {
                        return count.BeginningCount;
                    }
                }
                return 0;
            }
        }

        public int? retrieveMiddleCountID(int countId)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                var counts = context.Counts.ToList();

                foreach (var count in counts)
                {
                    if (count.CountId == countId)
                    {
                        return count.MiddleCount;
                    }
                }
                return 0;
            }
        }

        public int? retrieveEndingCountID(int countId)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                var counts = context.Counts.ToList();

                foreach (var count in counts)
                {
                    if (count.CountId == countId)
                    {
                        return count.EndingCount;
                    }
                }
                return 0;
            }
        }*/

        public bool addSpeaker(String fName, String lName, String eMail, String speakerPhone, String dayOfContact, String speakerBio, String speakerPastTalks)
        {
            SpeakerValidator validator = new SpeakerValidator();

            using CodeCampAppContext context = new CodeCampAppContext();
            {
                Speaker newSpeaker = new Speaker()
                {
                    SpeakerFname = fName,
                    SpeakerLname = lName,
                    SpeakerEmail = eMail,
                    SpeakerPhone = speakerPhone,
                    SpeakerDayOfContact = dayOfContact,
                    SpeakerBio = speakerBio,
                    SpeakerPastTalks = speakerPastTalks,
                };

                ValidationResult results = validator.Validate(newSpeaker);

                if (results.IsValid == false)
                {
                    String validationFailureMessage = "";

                    foreach (ValidationFailure failure in results.Errors)
                    {
                        validationFailureMessage += failure.ErrorMessage + "\n";
                    }

                    MessageBox.Show(validationFailureMessage);
                    return false;
                }
                else
                {
                    context.Speakers.Add(newSpeaker);
                    context.SaveChanges();
                    return true;
                }
            }
        }

        public bool deleteSpeaker(int speakerId)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                Speaker speakerToDelete = context.Speakers.Where(s => s.SpeakerId == speakerId).FirstOrDefault()!;

                if (speakerToDelete == null)
                {
                    return false;
                }
                else
                {
                    context.Speakers.Remove(speakerToDelete);
                    context.SaveChanges();
                    return true;
                }
            }
        }

        public bool addRoom(int maxOccupancy, String roomName)
        {
            RoomValidator validator = new RoomValidator();

            using CodeCampAppContext context = new CodeCampAppContext();
            {
                Room newRoom = new Room()
                {
                    RoomMaxOcc = maxOccupancy,
                    RoomName = roomName
                };

                ValidationResult results = validator.Validate(newRoom);

                if (results.IsValid == false)
                {
                    String validationFailureMessage = "";

                    foreach (ValidationFailure failure in results.Errors)
                    {
                        validationFailureMessage += failure.ErrorMessage + "\n";
                    }

                    MessageBox.Show(validationFailureMessage);
                    return false;
                }
                else
                {
                    context.Rooms.Add(newRoom);
                    context.SaveChanges();
                    return true;
                }
            }
        }

        public bool deleteRoom(int roomId)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                Room roomToDelete = context.Rooms.Where(r => r.RoomId == roomId).FirstOrDefault()!;
                if (roomToDelete == null)
                {
                    return false;
                }
                else
                {
                    context.Rooms.Remove(roomToDelete);
                    context.SaveChanges();
                    return true;
                }
            }
        }

        public bool addSession(String sessionTitle, String roomName, String speakerName, String timeSlot, String attendeeCountBegin, String attendeeCountMid, String attendeeCountEnd)
        {
            SessionValidator validator = new SessionValidator();

            using CodeCampAppContext context = new CodeCampAppContext();
            {
                Session newSession = new Session()
                {
                    SessionTitle = sessionTitle,
                    RoomId = retrieveRoomId(roomName),
                    SpeakerId = retrieveSpeakerId(speakerName),
                    TimeId = retrieveTimeId(timeSlot),
                    AttendeeCountBegin = Convert.ToInt32(attendeeCountBegin),
                    AttendeeCountMid = Convert.ToInt32(attendeeCountMid),
                    AttendeeCountEnd = Convert.ToInt32(attendeeCountEnd),
                };

                ValidationResult results = validator.Validate(newSession);

                if (results.IsValid == false)
                {
                    String validationFailureMessage = "";

                    foreach (ValidationFailure failure in results.Errors)
                    {
                        validationFailureMessage += failure.ErrorMessage + "\n";
                    }

                    MessageBox.Show(validationFailureMessage);
                    return false;
                }
                else
                {
                    context.Sessions.Add(newSession);
                    context.SaveChanges();
                    return true;
                }
            }
        }

        public bool deleteSession(int sessionId)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                Session sessionToDelete = context.Sessions.Where(s => s.SessionId == sessionId).FirstOrDefault()!;
                if (sessionToDelete == null)
                {
                    return false;
                }
                else
                {
                    context.Sessions.Remove(sessionToDelete);
                    context.SaveChanges();
                    return true;
                }
            }
        }

        public bool addTimeSlot(DateTime timeBegin, DateTime timeEnd)
        {
            TimeSlotValidator validator = new TimeSlotValidator();

            using CodeCampAppContext context = new CodeCampAppContext();
            {
                TimeSlot newTimeSlot = new TimeSlot()
                {
                    TimeBegin = timeBegin.TimeOfDay,
                    TimeEnd = timeEnd.TimeOfDay,
                    TimeDuration = timeEnd.TimeOfDay - timeBegin.TimeOfDay,
                };

                ValidationResult results = validator.Validate(newTimeSlot);

                if (results.IsValid == false)
                {
                    String validationFailureMessage = "";

                    foreach (ValidationFailure failure in results.Errors)
                    {
                        validationFailureMessage += failure.ErrorMessage + "\n";
                    }

                    MessageBox.Show(validationFailureMessage);
                    return false;
                }
                else
                {
                    context.TimeSlots.Add(newTimeSlot);
                    context.SaveChanges();
                    return true;
                }
            }
        }

        public bool deleteTimeSlot(int timeId)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                TimeSlot timeSlotToDelete = context.TimeSlots.Where(t => t.TimeId == timeId).FirstOrDefault()!;
                if (timeSlotToDelete == null)
                {
                    return false;
                }
                else
                {
                    context.TimeSlots.Remove(timeSlotToDelete);
                    context.SaveChanges();
                    return true;
                }
            }
        }

        public List<String> retrieveSpeakerNames()
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                List<string> speakersFullNames = new List<string>();

                var speakers = context.Speakers.ToList();

                foreach (var speaker in speakers)
                {
                    speakersFullNames.Add(speaker.SpeakerFname + " " + speaker.SpeakerLname);
                }
                return speakersFullNames;
            }
        }

        public List<String> retrieveSessionNames()
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                List<string> sessionNames = new List<string>();

                var sessions = context.Sessions.ToList();

                foreach (var session in sessions)
                {
                    sessionNames.Add(session.SessionTitle);
                }
                return sessionNames;
            }
        }

        public List<String> retrieveSpeakerNames(int aSpeakerId)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                List<string> speakersFullNames = new List<string>();

                var speakers = context.Speakers.ToList();

                foreach (var speaker in speakers)
                {
                    if (speaker.SpeakerId == aSpeakerId)
                    {
                        speakersFullNames.Add(speaker.SpeakerFname + " " + speaker.SpeakerLname);
                    }
                }
                return speakersFullNames;
            }
        }

        public List<String> retrieveSpeakersSessions(int aSpeakerId)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                List<string> speakersSessions = new List<string>();

                var sessions = context.Sessions.ToList();

                foreach (var session in sessions)
                {
                    if (session.SpeakerId == aSpeakerId)
                    {
                        speakersSessions.Add(session.SessionTitle);
                    }
                }
                return speakersSessions;
            }
        }

        public List<String> retrieveSessionTimeSlots(int aTimeId)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                List<string> speakersTimeSlots = new List<string>();

                var timeSlots = context.TimeSlots.ToList();

                foreach (var timeSlot in timeSlots)
                {
                    if (timeSlot.TimeId == aTimeId)
                    {
                        speakersTimeSlots.Add(timeSlot.TimeBegin.ToString() + " - " + timeSlot.TimeEnd.ToString());
                    }
                }
                return speakersTimeSlots;
            }
        }

        public int retrieveSessionId(String aSessionsName)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                var sessions = context.Sessions.ToList();

                foreach (var session in sessions)
                {
                    if (session.SessionTitle == aSessionsName)
                    {
                        return session.SessionId;
                    }
                }
                return 0;
            }
        }

        public int retrieveSessionTimeSlotId(String aSessionsName)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                var sessions = context.Sessions.ToList();

                foreach (var session in sessions)
                {
                    if (session.SessionTitle == aSessionsName)
                    {
                        return session.TimeId;
                    }
                }
                return 0;
            }
        }

        public int retrieveSpeakerId(String speakerName)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                var speakers = context.Speakers.ToList();

                foreach (var speaker in speakers)
                {
                    if (speaker.SpeakerFname + " " + speaker.SpeakerLname == speakerName)
                    {
                        return speaker.SpeakerId;
                    }
                }
                return 0;
            }
        }

        public List<String> retrieveRoomNames()
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                List<string> roomNames = new List<string>();

                var rooms = context.Rooms.ToList();

                foreach (var room in rooms)
                {
                    roomNames.Add(room.RoomName);
                }
                return roomNames;
            }
        }

        public int retrieveRoomId(String roomName)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                var rooms = context.Rooms.ToList();

                foreach (var room in rooms)
                {
                    if (room.RoomName == roomName)
                    {
                        return room.RoomId;
                    }
                }
                return 0;
            }
        }

        public int retieveRoomId(String sessionName)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                var sessions = context.Sessions.ToList();

                foreach (var session in sessions)
                {
                    if (session.SessionTitle == sessionName)
                    {
                        return session.RoomId;
                    }
                }
                return 0;
            }
        }

        public List<String> retrieveStartingTimeSlots()
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                List<string> timeSlots = new List<string>();

                var times = context.TimeSlots.ToList();

                foreach (var time in times)
                {
                    timeSlots.Add(time.TimeBegin.ToString());
                }
                return timeSlots;
            }
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

        public List<String> retrieveAFullTimeSlot()
        {
            using CodeCampAppContext context = new CodeCampAppContext();

            List<string> timeSlots = new List<string>();

            var times = context.TimeSlots.ToList();

            foreach (var time in times)
            {
                timeSlots.Add(time.TimeBegin.ToString() + " - " + time.TimeEnd.ToString());
            }
            return timeSlots;
        }

        public String retrieveSpeakersSessionDuration(int timeSlotId)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                String speakersTimeSlot = null!;

                var timeSlots = context.TimeSlots.ToList();

                foreach (var timeSlot in timeSlots)
                {
                    if (timeSlot.TimeId == timeSlotId)
                    {
                        speakersTimeSlot = timeSlot.TimeDuration.ToString()!;
                    }
                }
                return speakersTimeSlot;
            }
        }

        public String retrieveSpeakersRoomName(int sessionId)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                String speakersRoomName = null!;

                var rooms = context.Rooms.ToList();

                foreach (var room in rooms)
                {
                    if (room.RoomId == sessionId)
                    {
                        speakersRoomName = room.RoomName;
                    }
                }
                return speakersRoomName;
            }
        }

        public int retrieveTimeId(String timeSlot)
        {
            using CodeCampAppContext context = new CodeCampAppContext();
            {
                var times = context.TimeSlots.ToList();

                foreach (var time in times)
                {
                    if (time.TimeBegin.ToString() + " - " + time.TimeEnd.ToString() == timeSlot)
                    {
                        return time.TimeId;
                    }
                }
                return 0;
            }
        }
    }
}
