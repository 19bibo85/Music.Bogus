using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.Json;

namespace Music.Bogus.Loaders;

public abstract class MusicDataLoader<T>
{
    private static readonly ConcurrentDictionary<string, IList<T>> Cache = [];

    protected static IList<T> Entity(string name)
        => Cache.GetOrAdd(name, Load);

    private static Func<string, IList<T>> Load
        =>
            name
                =>
            {
                var assembly = typeof(MusicDataLoader<T>).Assembly;
                using var stream = assembly.GetManifestResourceStream("Music.Bogus.data.zip")!;
                using var archive = new ZipArchive(stream);

                return archive
                    .Entries
                    .SelectMany(Deserialize($"{name}.json"))
                    .ToList();
            };

    private static Func<ZipArchiveEntry, IEnumerable<T>> Deserialize(string filename)
        => entry
            => string.Equals(entry.Name, filename, StringComparison.InvariantCultureIgnoreCase)
                ? Deserialize(entry)
                : [];

    private static IEnumerable<T> Deserialize(ZipArchiveEntry entry)
    {
        using var stream = entry.Open();
        using var reader = new StreamReader(stream);
        return JsonSerializer.Deserialize<IEnumerable<T>>(reader.ReadToEnd()) ?? [];
    }
}