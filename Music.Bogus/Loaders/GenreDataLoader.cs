using Music.Bogus.Models;

namespace Music.Bogus.Loaders;

public class GenreDataLoader: MusicDataLoader<Genre>
{
    public static IList<Genre> Genres => Entity("genres");
}