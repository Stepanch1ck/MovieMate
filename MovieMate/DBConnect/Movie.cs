
namespace MovieMate.DBConnect;

public partial class Movie
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double? Grade { get; set; }

    public string? Link { get; set; }

    public string? Genre { get; set; }

    public byte[]? Picture { get; set; }
    public int Year { get; set; }
}
