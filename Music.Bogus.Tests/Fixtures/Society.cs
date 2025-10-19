namespace Music.Bogus.Tests.Fixtures;

internal sealed record Society
{
    public Society()
    {
        
    }

    internal Society(string? code, string? name, string? location, string? region)
    {
        Code = code;
        Name = name;
        Location = location;
        Region = region;
    }

    internal string? Code { set; get; }
    internal string? Name { set; get; }
    internal string? Location { set; get; }
    internal string? Region { set; get; }
}