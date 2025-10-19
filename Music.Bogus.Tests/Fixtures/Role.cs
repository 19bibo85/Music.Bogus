namespace Music.Bogus.Tests.Fixtures;

internal sealed record Role
{
    public Role()
    {
        
    }

    internal Role(string? code, string? description)
    {
        Code = code;
        Description = description;
    }

    internal string? Code { set; get; }
    internal string? Description { set; get; }
}