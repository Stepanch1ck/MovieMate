
namespace MovieMate.DBConnect;
public class Compilation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? IdMovie { get; set; }

    public string? IdPerson { get; set; }
}
