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

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

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
            entity.HasKey(e => e.RoomId).HasName("PK__tmp_ms_x__32863919F1F07E0F");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.RoomMaxOcc).HasColumnName("Room_MaxOcc");
            entity.Property(e => e.RoomName)
                .HasMaxLength(255)
                .HasColumnName("Room_Name");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PK__tmp_ms_x__C9F492703AC39CC7");

            entity.ToTable("Session");

            entity.Property(e => e.SessionId).HasColumnName("SessionID");
            entity.Property(e => e.AttendeeCountBegin).HasColumnName("Attendee_Count_Begin");
            entity.Property(e => e.AttendeeCountEnd).HasColumnName("Attendee_Count_End");
            entity.Property(e => e.AttendeeCountMid).HasColumnName("Attendee_Count_Mid");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.SessionTitle)
                .HasMaxLength(255)
                .HasColumnName("Session_Title");
            entity.Property(e => e.SpeakerId).HasColumnName("SpeakerID");
            entity.Property(e => e.TimeId).HasColumnName("TimeID");

            entity.HasOne(d => d.Room).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Session__RoomID__7EF6D905");

            entity.HasOne(d => d.Speaker).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.SpeakerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Session__Speaker__7C1A6C5A");

            entity.HasOne(d => d.Time).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.TimeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Session__TimeID__7755B73D");
        });

        modelBuilder.Entity<Speaker>(entity =>
        {
            entity.HasKey(e => e.SpeakerId).HasName("PK__tmp_ms_x__79E7573981C31987");

            entity.ToTable("Speaker");

            entity.Property(e => e.SpeakerId).HasColumnName("SpeakerID");
            entity.Property(e => e.SpeakerBio).HasColumnName("Speaker_Bio");
            entity.Property(e => e.SpeakerDayOfContact)
                .HasMaxLength(255)
                .HasColumnName("Speaker_DayOfContact");
            entity.Property(e => e.SpeakerEmail)
                .HasMaxLength(255)
                .HasColumnName("Speaker_Email");
            entity.Property(e => e.SpeakerFname)
                .HasMaxLength(255)
                .HasColumnName("Speaker_FName");
            entity.Property(e => e.SpeakerLname)
                .HasMaxLength(255)
                .HasColumnName("Speaker_LName");
            entity.Property(e => e.SpeakerPastTalks).HasColumnName("Speaker_PastTalks");
            entity.Property(e => e.SpeakerPhone)
                .HasMaxLength(50)
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
