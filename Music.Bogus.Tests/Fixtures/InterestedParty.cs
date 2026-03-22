namespace Music.Bogus.Tests.Fixtures;

internal sealed record InterestedParty
{
    public InterestedParty() 
    {
        
    }
    
    internal InterestedParty(IPI ipiBaseNumber, IList<IPI> ipiNameNumbers, string? name, IList<Society> societies)
    {
        IPIBaseNumber = ipiBaseNumber;
        IPINameNumbers = ipiNameNumbers;
        Name = name;
        Societies = societies;
    }

    internal IPI IPIBaseNumber { get; set; } = new();

    internal IList<IPI> IPINameNumbers { get; set; } = [];
    
    internal string? Name { get; set; }

    internal IList<Society> Societies { get; set; } = [];
}