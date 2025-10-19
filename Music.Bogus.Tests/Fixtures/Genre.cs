namespace Music.Bogus.Tests.Fixtures;

internal sealed record Genre
{
    public Genre() 
    {
        
    }
    
    internal Genre(string? code, string? name)
    {
        Code = code;
        Name = name;
    }

    internal string? Code { get; set; }
    internal string? Name { get; set; }
}