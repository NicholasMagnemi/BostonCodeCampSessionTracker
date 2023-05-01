using System;
using System.Collections.Generic;
using System.Configuration;
using BostonCodeCampSessionTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BostonCodeCampSessionTracker.Data;

public partial class CodeCampAppContext : DbContext
{
    public CodeCampAppContext()
    {
    }

    public CodeCampAppContext(DbContextOptions<CodeCampAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Count> Counts { get; set; }

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
        modelBuilder.Entity<Count>(entity =>
        {
            entity.Property(e => e.CountId).HasColumnName("countID");
            entity.Property(e => e.BeginningCount).HasColumnName("beginning_count");
            entity.Property(e => e.EndingCount).HasColumnName("ending_count");
            entity.Property(e => e.MiddleCount).HasColumnName("middle_count");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__tmp_ms_x__32863919DEC92F2D");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.RoomMaxOcc).HasColumnName("Room_MaxOcc");
            entity.Property(e => e.RoomName)
                .HasColumnType("text")
                .HasColumnName("Room_Name");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PK__tmp_ms_x__C9F492701D8A8BAF");

            entity.ToTable("Session");

            entity.Property(e => e.SessionId).HasColumnName("SessionID");
            entity.Property(e => e.CountId).HasColumnName("CountID");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.SessionTitle)
                .HasColumnType("text")
                .HasColumnName("Session_Title");
            entity.Property(e => e.SpeakerId).HasColumnName("SpeakerID");
            entity.Property(e => e.TimeId).HasColumnName("TimeID");

            entity.HasOne(d => d.Count).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.CountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Session__CountID__607251E5");

            entity.HasOne(d => d.Room).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Session__RoomID__2739D489");

            entity.HasOne(d => d.Speaker).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.SpeakerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Session__Speaker__282DF8C2");

            entity.HasOne(d => d.Time).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.TimeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Session__TimeID__2DE6D218");
        });

        modelBuilder.Entity<SessionSpeaker>(entity =>
        {
            entity.HasKey(e => e.SessionSpeakerId).HasName("PK__tmp_ms_x__9282E49C49F25259");

            entity.ToTable("Session+Speaker");

            entity.Property(e => e.SessionSpeakerId).HasColumnName("SessionSpeakerID");
            entity.Property(e => e.SessionId).HasColumnName("SessionID");
            entity.Property(e => e.SpeakerId).HasColumnName("SpeakerID");

            entity.HasOne(d => d.Session).WithMany(p => p.SessionSpeakers)
                .HasForeignKey(d => d.SessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Session+S__Sessi__2B0A656D");

            entity.HasOne(d => d.Speaker).WithMany(p => p.SessionSpeakers)
                .HasForeignKey(d => d.SpeakerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Session+S__Speak__2A164134");
        });

        modelBuilder.Entity<Speaker>(entity =>
        {
            entity.HasKey(e => e.SpeakerId).HasName("PK__tmp_ms_x__79E7573944388911");

            entity.ToTable("Speaker");

            entity.Property(e => e.SpeakerId).HasColumnName("SpeakerID");
            entity.Property(e => e.SpeakerBio)
                .HasColumnType("text")
                .HasColumnName("Speaker_Bio");
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
            entity.Property(e => e.SpeakerPastTalks)
                .HasColumnType("text")
                .HasColumnName("Speaker_PastTalks");
            entity.Property(e => e.SpeakerPhone)
                .HasColumnType("text")
                .HasColumnName("Speaker_Phone");
        });

        modelBuilder.Entity<TimeSlot>(entity =>
        {
            entity.HasKey(e => e.TimeId).HasName("PK__tmp_ms_x__E04ED9676C0653AE");

            entity.Property(e => e.TimeId).HasColumnName("TimeID");
            entity.Property(e => e.TimeBegin).HasColumnName("Time_Begin");
            entity.Property(e => e.TimeDuration).HasColumnName("Time_Duration");
            entity.Property(e => e.TimeEnd).HasColumnName("Time_End");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
