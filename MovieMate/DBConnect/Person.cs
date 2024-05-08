
namespace MovieMate.DBConnect;

public partial class Person
{
    public int Id { get; set; }

    public string Nickname { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? Email { get; set; }

    public string? IdMovieLike { get; set; }

    public string? IdBlackList { get; set; }

    public string? IdFavorites { get; set; }

    public byte[]? Picture { get; set; }
}
