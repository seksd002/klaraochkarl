using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KlaraKarl;

public partial class KlarakarldbContext : DbContext
{
    public KlarakarldbContext()
    {
    }

    public KlarakarldbContext(DbContextOptions<KlarakarldbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Allergy> Allergies { get; set; }

    public virtual DbSet<Participant> Participants { get; set; }

    public virtual DbSet<ParticipantType> ParticipantTypes { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Rwsp> Rwsps { get; set; }

    public virtual DbSet<Wedding> Weddings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("DataSource=Klarakarldb.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Allergy>(entity =>
        {
            entity.Property(e => e.Allergy1).HasColumnName("Allergy");

            entity.HasOne(d => d.Rwsp).WithMany(p => p.Allergies).HasForeignKey(d => d.RwspId);
        });

        modelBuilder.Entity<Participant>(entity =>
        {
            entity.ToTable("Participant");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Participants).HasForeignKey(d => d.Type);
        });

        modelBuilder.Entity<ParticipantType>(entity =>
        {
            entity.ToTable("ParticipantType");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.ToTable("Person");
        });

        modelBuilder.Entity<Rwsp>(entity =>
        {
            entity.ToTable("Rwsp");

            entity.HasOne(d => d.Person).WithMany(p => p.Rwsps).HasForeignKey(d => d.PersonId);
        });

        modelBuilder.Entity<Wedding>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Wedding");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
