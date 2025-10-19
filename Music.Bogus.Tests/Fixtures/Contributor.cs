namespace Music.Bogus.Tests.Fixtures;

internal sealed record Contributor
{
    public Contributor() 
    {
        
    }
    
    internal Contributor(InterestedParty interestedParty, Role role, double? share)
    {
        InterestedParty = interestedParty;
        Role = role;
        Share = share;
    }

    internal InterestedParty InterestedParty { get; set; } = new();
    internal Role Role { get; set; } = new();

    internal double? Share { get; set; }
}