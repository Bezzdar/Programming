public class Song
{
    public string Name { get; set; }
    public string Singer { get; set; }
    public Genre Genre { get; set; }
    public int Duration { get; set; }

    public override string ToString()
    {
        return $"{Singer} - {Name}" ;
    }
}

public enum Genre
{
    Pop,
    Rock,
    HipHop,
    Electronic,
    Classical,
    Jazz,
    Blues,
    Country,
    Reggae,
    Folk
}
