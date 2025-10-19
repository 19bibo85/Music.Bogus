using Bogus;
using Music.Bogus.Loaders;
using Music.Bogus.Models;

namespace Music.Bogus;

public sealed class MusicDataSet : DataSet
{
    public MusicDataSet(Randomizer? randomizer = null)
    {
        if (randomizer != null)
        {
            Random = randomizer;
        }
    }

    public Role Role() => RandomRole();
    
    public IEnumerable<Role> Roles(int num = 1)
    {
        Guard.AgainstNegative(num, nameof(num));
        for (var i = 0; i < num; i++)
        {
            yield return RandomRole();
        }
    }

    private Role RandomRole()
    {
        var index = Random.Number(RoleDataLoader.Roles.Count - 1);
        return RoleDataLoader.Roles[index];
    }
    
    public Society Society() => RandomSociety();
    
    public IEnumerable<Society> Societies(int num = 1)
    {
        Guard.AgainstNegative(num, nameof(num));
        for (var i = 0; i < num; i++)
        {
            yield return RandomSociety();
        }
    }
    
    private Society RandomSociety()
    {
        var index = Random.Number(SocietyDataLoader.Societies.Count - 1);
        return SocietyDataLoader.Societies[index];
    }
    
    public Genre Genre() => RandomGenre();
    
    public IEnumerable<Genre> Genres(int num = 1)
    {
        Guard.AgainstNegative(num, nameof(num));
        for (var i = 0; i < num; i++)
        {
            yield return RandomGenre();
        }
    }
    
    private Genre RandomGenre()
    {
        var index = Random.Number(GenreDataLoader.Genres.Count - 1);
        return GenreDataLoader.Genres[index];
    }
    
    public IPI IPI() => RandomIPI();
    
    public IEnumerable<IPI> IPIs(int num = 1)
    {
        Guard.AgainstNegative(num, nameof(num));
        for (var i = 0; i < num; i++)
        {
            yield return RandomIPI();
        }
    }
    
    private IPI RandomIPI()
    {
        var index = Random.Number(IPIDataLoader.IPIs.Count - 1);
        return IPIDataLoader.IPIs[index];
    }
    
    public WorkTitle WorkTitle() => RandomWorkTitle();
    
    public IEnumerable<WorkTitle> WorkTitles(int num = 1)
    {
        Guard.AgainstNegative(num, nameof(num));
        for (var i = 0; i < num; i++)
        {
            yield return RandomWorkTitle();
        }
    }
    
    private WorkTitle RandomWorkTitle()
    {
        var index = Random.Number(WorkTitleDataLoader.WorkTitles.Count - 1);
        return WorkTitleDataLoader.WorkTitles[index];
    }
}