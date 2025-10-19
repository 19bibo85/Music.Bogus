using Music.Bogus.Models;

namespace Music.Bogus.Loaders;

public sealed class RoleDataLoader : MusicDataLoader<Role>
{
    public static IList<Role> Roles => Entity("roles");
}