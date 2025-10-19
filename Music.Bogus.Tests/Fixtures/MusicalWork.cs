using System.Collections.Generic;

namespace Music.Bogus.Tests.Fixtures;

internal sealed class MusicalWork
{
    public MusicalWork()
    {
        
    }
    
    internal MusicalWork(WorkTitle title, Genre genre, double duration, IList<Contributor> contributors)
    {
        Title = title;
        Genre = genre;
        Duration = duration;
        Contributors = contributors;
    }

    internal WorkTitle Title { get; set; } = new();

    internal Genre Genre { get; set; } = new();
    
    internal double Duration { get; set; }

    internal IList<Contributor> Contributors { get; set; } = [];
}