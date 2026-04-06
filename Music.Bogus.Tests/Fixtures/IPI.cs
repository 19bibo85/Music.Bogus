namespace Music.Bogus.Tests.Fixtures;

internal sealed record IPI
{
    public IPI() 
    {
        
    }

    internal IPI(string? baseNumber, long? nameNumber, string? name)
    {
        BaseNumber = baseNumber;
        NameNumber = nameNumber;
        Name = name;
    }
    
    internal string? BaseNumber { get; set; }
    internal long? NameNumber { get; set; }
    internal string? Name { get; set; }
}