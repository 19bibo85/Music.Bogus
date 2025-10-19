using Music.Bogus.Models;

namespace Music.Bogus.Loaders;

public class WorkTitleDataLoader: MusicDataLoader<WorkTitle>
{
    public static IList<WorkTitle> WorkTitles => Entity("work_titles");
}