namespace Music.Bogus.Tests.Fixtures;

internal sealed record IPI
{
    public IPI() 
    {
        
    }

    internal IPI(string? baseNumber, string? nameNumber, string? name)
    {
        BaseNumber = baseNumber;
        NameNumber = nameNumber;
        Name = name;
    }
    
    internal string? BaseNumber { get; set; }
    internal string? NameNumber { get; set; }
    internal string? Name { get; set; }
}