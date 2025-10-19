using Music.Bogus.Models;

namespace Music.Bogus.Loaders;

public class SocietyDataLoader : MusicDataLoader<Society>
{
    public static IList<Society> Societies => Entity("societies");
}