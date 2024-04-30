using Microsoft.EntityFrameworkCore;

namespace MovieMate.DBConnect;

public partial class MovieDbContext : DbContext
{
    public MovieDbContext()
    {
    }

    public MovieDbContext(DbContextOptions<MovieDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite(@"Data Source=../../../DBConnect/MovieDB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.ToTable("Movie");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Genre)
                .HasColumnType("VARCHAR(255)")
                .HasColumnName("genre");
            entity.Property(e => e.Grade)
                .HasColumnType("FLOAT")
                .HasColumnName("grade");
            entity.Property(e => e.Link)
                .HasColumnType("MEDIUMTEXT")
                .HasColumnName("link");
            entity.Property(e => e.Name)
                .HasColumnType("VARCHAR(255)")
                .HasColumnName("name");
            entity.Property(e => e.Picture)
                .HasColumnType("IMAGE")
                .HasColumnName("picture");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.ToTable("Person");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdBlackList)
                .HasColumnType("VARCHAR(255)")
                .HasColumnName("idBlackList");
            entity.Property(e => e.IdFavorites)
                .HasColumnType("VARCHAR(255)")
                .HasColumnName("idFavorites");
            entity.Property(e => e.IdMovieLike)
                .HasColumnType("VARCHAR(255)")
                .HasColumnName("idMovieLike");
            entity.Property(e => e.Nickname)
                .HasColumnType("VARCHAR(255)")
                .HasColumnName("nickname");
            entity.Property(e => e.Picture)
                .HasColumnType("IMAGE")
                .HasColumnName("picture");

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
