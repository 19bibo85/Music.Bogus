using Bogus;
using Bogus.Premium;

namespace Music.Bogus.Extensions;

public static class BogusExtensions
{
    public static MusicDataSet Musics(this Faker faker) =>
        ContextHelper.GetOrSet(faker, () => new MusicDataSet(faker.Random));
}