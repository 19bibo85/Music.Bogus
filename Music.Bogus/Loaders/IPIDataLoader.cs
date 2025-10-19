using Music.Bogus.Models;

namespace Music.Bogus.Loaders;

public class IPIDataLoader: MusicDataLoader<IPI>
{
    public static IList<IPI> IPIs => Entity("ipis");
}