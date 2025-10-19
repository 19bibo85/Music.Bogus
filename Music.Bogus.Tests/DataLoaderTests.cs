using Music.Bogus.Tests.Fixtures;
using Xunit;

namespace Music.Bogus.Tests;

public sealed class DataLoaderTests
{
    [Fact]
    public void InvokeRole_GeneratingRandomValue_PropertiesAreValid()
    {
        var role = MusicGenerator
            .GenerateRoles
            .Generate();
        
        Assert.NotNull(role);
        Assert.NotNull(role.Code);
        Assert.NotNull(role.Description);
    }
    
    [Fact]
    public void InvokeRole2_GeneratingRandomValue_PropertiesAreValid()
    {
        var role = MusicGenerator
            .GenerateRoles2
            .Generate();
        
        Assert.NotNull(role);
        Assert.NotNull(role.Code);
        Assert.NotNull(role.Description);
    }
    
    [Fact]
    public void InvokeRoles_GeneratingRandomValue_CollectionIsValid()
    {
        var roles = MusicGenerator
            .GenerateRoles
            .Generate(10);
        
        Assert.NotNull(roles);
        Assert.NotEmpty(roles);
    }
    
    [Fact]
    public void InvokeSociety_GeneratingRandomValue_PropertiesAreValid()
    {
        var society = MusicGenerator
            .GenerateSocieties
            .Generate();
        
        Assert.NotNull(society);
        Assert.NotNull(society.Code);
        Assert.NotNull(society.Name);
        Assert.NotNull(society.Location);
        Assert.NotNull(society.Region);
    }
    
    [Fact]
    public void InvokeSociety2_GeneratingRandomValue_PropertiesAreValid()
    {
        var society = MusicGenerator
            .GenerateSocieties2
            .Generate();
        
        Assert.NotNull(society);
        Assert.NotNull(society.Code);
        Assert.NotNull(society.Name);
        Assert.NotNull(society.Location);
        Assert.NotNull(society.Region);
    }
    
    [Fact]
    public void InvokeSocieties_GeneratingRandomValue_CollectionIsValid()
    {
        var societies = MusicGenerator
            .GenerateSocieties
            .Generate(10);
        
        Assert.NotNull(societies);
        Assert.NotEmpty(societies);
    }
    
    [Fact]
    public void InvokeGenre_GeneratingRandomValue_PropertiesAreValid()
    {
        var genre = MusicGenerator
            .GenerateGenres
            .Generate();
        
        Assert.NotNull(genre);
        Assert.NotNull(genre.Code);
        Assert.NotNull(genre.Name);
    }
    
    [Fact]
    public void InvokeGenre2_GeneratingRandomValue_PropertiesAreValid()
    {
        var genre = MusicGenerator
            .GenerateGenres2
            .Generate();
        
        Assert.NotNull(genre);
        Assert.NotNull(genre.Code);
        Assert.NotNull(genre.Name);
    }
    
    [Fact]
    public void InvokeGenres_GeneratingRandomValue_CollectionIsValid()
    {
        var genres = MusicGenerator
            .GenerateGenres
            .Generate(10);
        
        Assert.NotNull(genres);
        Assert.NotEmpty(genres);
    }
    
    [Fact]
    public void InvokeIPI_GeneratingRandomValue_PropertiesAreValid()
    {
        var ips = MusicGenerator
            .GenerateIPIs
            .Generate();
        
        Assert.NotNull(ips);
        Assert.NotNull(ips.BaseNumber);
        Assert.NotNull(ips.NameNumber);
        Assert.NotNull(ips.Name);
    }
    
    [Fact]
    public void InvokeIPI2_GeneratingRandomValue_PropertiesAreValid()
    {
        var ips = MusicGenerator
            .GenerateIPIs2
            .Generate();
        
        Assert.NotNull(ips);
        Assert.NotNull(ips.BaseNumber);
        Assert.NotNull(ips.NameNumber);
        Assert.NotNull(ips.Name);
    }
    
    [Fact]
    public void InvokeIPIs_GeneratingRandomValue_CollectionIsValid()
    {
        var ips = MusicGenerator
            .GenerateIPIs
            .Generate(10);
        
        Assert.NotNull(ips);
        Assert.NotEmpty(ips);
    }
    
    [Fact]
    public void InvokeWorkTitle_GeneratingRandomValue_PropertiesAreValid()
    {
        var workTitle = MusicGenerator
            .GenerateWorkTitles
            .Generate();
        
        Assert.NotNull(workTitle);
        Assert.NotNull(workTitle.ISWC);
        Assert.NotNull(workTitle.Title);
        Assert.NotNull(workTitle.LanguageCode);
        Assert.NotNull(workTitle.IsOriginal);
    }
    
    [Fact]
    public void InvokeWorkTitle2_GeneratingRandomValue_PropertiesAreValid()
    {
        var workTitle = MusicGenerator
            .GenerateWorkTitles2
            .Generate();
        
        Assert.NotNull(workTitle);
        Assert.NotNull(workTitle.ISWC);
        Assert.NotNull(workTitle.Title);
        Assert.NotNull(workTitle.LanguageCode);
        Assert.NotNull(workTitle.IsOriginal);
    }
    
    [Fact]
    public void InvokeWorkTitles_GeneratingRandomValue_CollectionIsValid()
    {
        var workTitles = MusicGenerator
            .GenerateWorkTitles
            .Generate(10);
        
        Assert.NotNull(workTitles);
        Assert.NotEmpty(workTitles);
    }
    
    [Fact]
    public void InvokeInterestedParty_GeneratingRandomValue_PropertiesAreValid()
    {
        var interestedParty = MusicGenerator
            .GenerateInterestedParties
            .Generate();
        
        Assert.NotNull(interestedParty);
        Assert.NotNull(interestedParty.IPIBaseNumber);
        Assert.NotNull(interestedParty.IPIBaseNumber.Name);
        Assert.NotNull(interestedParty.IPIBaseNumber.NameNumber);
        Assert.NotNull(interestedParty.IPINameNumbers);
        Assert.Single(interestedParty.IPINameNumbers);
        Assert.NotNull(interestedParty.IPINameNumbers[0].Name);
        Assert.NotNull(interestedParty.IPINameNumbers[0].NameNumber);
        Assert.NotNull(interestedParty.Societies);
        Assert.Single(interestedParty.Societies);
        Assert.NotNull(interestedParty.Societies[0].Code);
        Assert.NotNull(interestedParty.Societies[0].Name);
        Assert.NotNull(interestedParty.Societies[0].Location);
        Assert.NotNull(interestedParty.Societies[0].Region);
    }
    
    [Fact]
    public void InvokeInterestedParty2_GeneratingRandomValue_PropertiesAreValid()
    {
        var interestedParty = MusicGenerator
            .GenerateInterestedParties2
            .Generate();
        
        Assert.NotNull(interestedParty);
        Assert.NotNull(interestedParty.IPIBaseNumber);
        Assert.NotNull(interestedParty.IPIBaseNumber.Name);
        Assert.NotNull(interestedParty.IPIBaseNumber.NameNumber);
        Assert.NotNull(interestedParty.IPINameNumbers);
        Assert.Single(interestedParty.IPINameNumbers);
        Assert.NotNull(interestedParty.IPINameNumbers[0].Name);
        Assert.NotNull(interestedParty.IPINameNumbers[0].NameNumber);
        Assert.NotNull(interestedParty.Societies);
        Assert.Single(interestedParty.Societies);
        Assert.NotNull(interestedParty.Societies[0].Code);
        Assert.NotNull(interestedParty.Societies[0].Name);
        Assert.NotNull(interestedParty.Societies[0].Location);
        Assert.NotNull(interestedParty.Societies[0].Region);
    }
    
    [Fact]
    public void InvokeContributor_GeneratingRandomValue_PropertiesAreValid()
    {
        var contributor = MusicGenerator
            .GenerateContributors
            .Generate();
        
        Assert.NotNull(contributor);
        Assert.NotNull(contributor.InterestedParty);
        Assert.NotNull(contributor.InterestedParty.Name);
        Assert.NotNull(contributor.InterestedParty.IPIBaseNumber);
        Assert.NotNull(contributor.InterestedParty.IPINameNumbers);
        Assert.NotNull(contributor.InterestedParty.Societies);
        Assert.NotNull(contributor.Role);
        Assert.NotNull(contributor.Role.Code);
        Assert.NotNull(contributor.Role.Description);
        Assert.NotNull(contributor.Share);
    }
    
    [Fact]
    public void InvokeContributor2_GeneratingRandomValue_PropertiesAreValid()
    {
        var contributor = MusicGenerator
            .GenerateContributors2
            .Generate();
        
        Assert.NotNull(contributor);
        Assert.NotNull(contributor.InterestedParty);
        Assert.NotNull(contributor.InterestedParty.Name);
        Assert.NotNull(contributor.InterestedParty.IPIBaseNumber);
        Assert.NotNull(contributor.InterestedParty.IPINameNumbers);
        Assert.NotNull(contributor.InterestedParty.Societies);
        Assert.NotNull(contributor.Role);
        Assert.NotNull(contributor.Role.Code);
        Assert.NotNull(contributor.Role.Description);
        Assert.NotNull(contributor.Share);
    }
    
    [Fact]
    public void InvokeMusicalWork_GeneratingRandomValue_PropertiesAreValid()
    {
        var musicalWorks = MusicGenerator
            .GenerateMusicalWorks
            .Generate();
        
        Assert.NotNull(musicalWorks);
    }
}