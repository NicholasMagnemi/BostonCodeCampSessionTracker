using BostonCodeCampSessionTracker.Data;
using BostonCodeCampSessionTracker.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace BostonCodeCampSessionTracker.mocks
{
    [TestFixture]
    public class SpeakerMock
    {
        private static DbContextOptions<CodeCampAppContext> dbContextOptions = new DbContextOptionsBuilder<CodeCampAppContext>()
            .UseInMemoryDatabase(databaseName: "CodeCampSessionTrackerTest")
            .Options;

        CodeCampAppContext context;

        [OneTimeSetUp]
        public void setup()
        {
            context = new CodeCampAppContext(dbContextOptions);

            context.Database.EnsureCreated();

            SeedDatabase();
        }

        [OneTimeTearDown]
        public void cleanUp()
        {
            context.Database.EnsureDeleted();
        }

        private void SeedDatabase()
        {
            var counts = new List<Count>()
            {
                new Count() { CountId = 1, BeginningCount = 1, MiddleCount = 2, EndingCount = 3 },
                new Count() { CountId = 2, BeginningCount = 4, MiddleCount = 5, EndingCount = 6 },
                new Count() { CountId = 3, BeginningCount = 7, MiddleCount = 8, EndingCount = 9 },
                new Count() { CountId = 4, BeginningCount = 10, MiddleCount = 11, EndingCount = 12 },
                new Count() { CountId = 5, BeginningCount = 13, MiddleCount = 14, EndingCount = 15 },
                new Count() { CountId = 6, BeginningCount = 16, MiddleCount = 17, EndingCount = 18 },
                new Count() { CountId = 7, BeginningCount = 19, MiddleCount = 20, EndingCount = 21 },
                new Count() { CountId = 8, BeginningCount = 22, MiddleCount = 23, EndingCount = 24 },
                new Count() { CountId = 9, BeginningCount = 25, MiddleCount = 26, EndingCount = 27 },
                new Count() { CountId = 10, BeginningCount = 28, MiddleCount = 29, EndingCount = 30 },
                new Count() { CountId = 11, BeginningCount = 31, MiddleCount = 32, EndingCount = 33 },
                new Count() { CountId = 12, BeginningCount = 34, MiddleCount = 35, EndingCount = 36 },
                new Count() { CountId = 13, BeginningCount = 37, MiddleCount = 38, EndingCount = 39 },
                new Count() { CountId = 14, BeginningCount = 40, MiddleCount = 41, EndingCount = 42 },
                new Count() { CountId = 15, BeginningCount = 43, MiddleCount = 44, EndingCount = 45 },
                new Count() { CountId = 16, BeginningCount = 46, MiddleCount = 47, EndingCount = 48 },
                new Count() { CountId = 17, BeginningCount = 49, MiddleCount = 50, EndingCount = 51 },
            };
            context.Counts.AddRange(counts);

            var speakers = new List<Speaker>()
            {
                new Speaker() { SpeakerId = 1, SpeakerFname = "Speaker 1", SpeakerLname = "Speaker 1", SpeakerBio = "Speaker 1 Bio", SpeakerEmail = "Test@test.com", SpeakerDayOfContact = "5555555555", SpeakerPhone = "5555555555", SpeakerPastTalks = "Speaker 1 Past Talks"}
            };
            context.Speakers.AddRange(speakers);

            var rooms = new List<Room>()
            {
                new Room() { RoomId = 1, RoomName = "Test", RoomMaxOcc = 65 },
            };
            context.Rooms.AddRange(rooms);

            var sessions = new List<Session>()
            {
                new Session() { SessionId = 1, SessionTitle = "test", RoomId = 1, SpeakerId = 1, TimeId = 1, CountId = 1 },
            };
            context.Sessions.AddRange(sessions);

            var times = new List<TimeSlot>()
            {
                new TimeSlot() { TimeId = 1, TimeBegin = TimeSpan.Parse("10:00 "), TimeEnd = TimeSpan.Parse("11:00")},
            };
            context.Sessions.AddRange(sessions);

            context.SaveChanges();
        }

    }
}

