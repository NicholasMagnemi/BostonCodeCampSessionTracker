using Microsoft.EntityFrameworkCore;
using SemesterProjectTest.Models;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace SemesterProjectTest.Data
{
    public partial class CodeCampAppContext : DbContext
    {
        public CodeCampAppContext()
        {
        }

        public CodeCampAppContext(DbContextOptions<CodeCampAppContext> options) : base(options)
        {
        }

        public virtual DbSet<Room> Rooms { get; set; }

        public virtual DbSet<Session> Sessions { get; set; }

        public virtual DbSet<SessionSpeaker> SessionSpeakers { get; set; }

        public virtual DbSet<Speaker> Speakers { get; set; }

        public virtual DbSet<TimeSlot> TimeSlots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["CodeCampAppDatabase"].ConnectionString);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.RoomId).HasName("PK__tmp_ms_x__32863919254C2108");

                entity.Property(e => e.RoomId)
                    .ValueGeneratedNever()
                    .HasColumnName("RoomID");
                entity.Property(e => e.RoomMaxOcc).HasColumnName("Room_MaxOcc");
                entity.Property(e => e.RoomName)
                    .HasColumnType("text")
                    .HasColumnName("Room_Name");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasKey(e => e.SessionId).HasName("PK__tmp_ms_x__C9F49270CE87D2F4");

                entity.ToTable("Session");

                entity.Property(e => e.SessionId)
                    .ValueGeneratedNever()
                    .HasColumnName("SessionID");
                entity.Property(e => e.RoomId).HasColumnName("RoomID");
                entity.Property(e => e.SessionTitle)
                    .HasColumnType("text")
                    .HasColumnName("Session_Title");
                entity.Property(e => e.SpeakerId).HasColumnName("SpeakerID");
                entity.Property(e => e.TimeId).HasColumnName("TimeID");
            });

            modelBuilder.Entity<SessionSpeaker>(entity =>
            {
                entity.HasKey(e => e.SessionSpeakerId).HasName("PK__tmp_ms_x__9282E49CCEB79848");

                entity.ToTable("Session+Speaker");

                entity.Property(e => e.SessionSpeakerId)
                    .ValueGeneratedNever()
                    .HasColumnName("SessionSpeakerID");
                entity.Property(e => e.SessionId).HasColumnName("SessionID");
                entity.Property(e => e.SpeakerId).HasColumnName("SpeakerID");
            });

            modelBuilder.Entity<Speaker>(entity =>
            {
                entity.HasKey(e => e.SpeakerId).HasName("PK__tmp_ms_x__79E75739C60376C3");

                entity.ToTable("Speaker");

                entity.Property(e => e.SpeakerId)
                    .ValueGeneratedNever()
                    .HasColumnName("SpeakerID");
                entity.Property(e => e.SpeakerDayOfContact)
                    .HasColumnType("text")
                    .HasColumnName("Speaker_DayOfContact");
                entity.Property(e => e.SpeakerEmail)
                    .HasColumnType("text")
                    .HasColumnName("Speaker_Email");
                entity.Property(e => e.SpeakerFname)
                    .HasColumnType("text")
                    .HasColumnName("Speaker_FName");
                entity.Property(e => e.SpeakerLname)
                    .HasColumnType("text")
                    .HasColumnName("Speaker_LName");
                entity.Property(e => e.SpeakerPhone)
                    .HasColumnType("text")
                    .HasColumnName("Speaker_Phone");
            });

            modelBuilder.Entity<TimeSlot>(entity =>
            {
                entity.HasKey(e => e.TimeId).HasName("PK__tmp_ms_x__E04ED967A833F469");

                entity.Property(e => e.TimeId)
                    .ValueGeneratedNever()
                    .HasColumnName("TimeID");
                entity.Property(e => e.TimeBegin).HasColumnName("Time_Begin");
                entity.Property(e => e.TimeDuration)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("Time_Duration");
                entity.Property(e => e.TimeEnd).HasColumnName("Time_End");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}