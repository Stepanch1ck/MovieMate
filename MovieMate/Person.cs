using System;
using System.Collections.Generic;

namespace MovieMate;

public partial class Person
{
    public int Id { get; set; }

    public string Nickname { get; set; } = null!;

    public string? IdMovieLike { get; set; }

    public string? IdBlackList { get; set; }

    public string? IdFavorites { get; set; }

    public byte[]? Picture { get; set; }
}
