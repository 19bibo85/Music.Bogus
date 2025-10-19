using System.Collections.Generic;
using Bogus;
using Music.Bogus.Extensions;

namespace Music.Bogus.Tests.Fixtures;

internal static class MusicGenerator
{
    internal static Faker<Role> GenerateRoles
        => new Faker<Role>()
            .CustomInstantiator(f =>
            {
                var role = f.Musics().Role();
                return new Role(role.Code, role.Description);
            });
    
    internal static Faker<Role> GenerateRoles2
        => new Faker<Role>()
            .RuleFor(
                property: u => u.Code,
                setter: (f, _) => f.Musics().Role().Code)
            .RuleFor(
                property: u => u.Description,
                setter: (f, _) => f.Musics().Role().Description);
    
    internal static Faker<Society> GenerateSocieties
        => new Faker<Society>()
            .CustomInstantiator(f =>
            {
                var society = f.Musics().Society();
                return new Society(society.Code, society.Name, society.Location, society.Region);
            });
    
    internal static Faker<Society> GenerateSocieties2
        => new Faker<Society>()
            .RuleFor(
                property: u => u.Code,
                setter: (f, _) => f.Musics().Society().Code)
            .RuleFor(
                property: u => u.Name,
                setter: (f, _) => f.Musics().Society().Name)
            .RuleFor(
                property: u => u.Location,
                setter: (f, _) => f.Musics().Society().Location)
            .RuleFor(
                property: u => u.Region,
                setter: (f, _) => f.Musics().Society().Region);
    
    internal static Faker<Genre> GenerateGenres
        => new Faker<Genre>()
            .CustomInstantiator(f =>
            {
                var genre = f.Musics().Genre();
                return new Genre(genre.Code, genre.Name);
            });
    
    internal static Faker<Genre> GenerateGenres2
        => new Faker<Genre>()
            .RuleFor(
                property: u => u.Code,
                setter: (f, _) => f.Musics().Genre().Code)
            .RuleFor(
                property: u => u.Name,
                setter: (f, _) => f.Musics().Genre().Name);
    
    internal static Faker<IPI> GenerateIPIs
        => new Faker<IPI>()
            .CustomInstantiator(f =>
            {
                var ipi = f.Musics().IPI();
                return new IPI(ipi.BaseNumber, ipi.NameNumber, ipi.Name);
            });

    internal static Faker<IPI> GenerateIPIs2
        => new Faker<IPI>()
            .RuleFor(
                property: u => u.BaseNumber,
                setter: (f, _) => f.Musics().IPI().BaseNumber)
            .RuleFor(
                property: u => u.NameNumber,
                setter: (f, _) => f.Musics().IPI().NameNumber)
            .RuleFor(
                property: u => u.Name,
                setter: (f, _) => f.Musics().IPI().Name);
    
    internal static Faker<WorkTitle> GenerateWorkTitles
        => new Faker<WorkTitle>()
            .CustomInstantiator(f =>
            {
                var workTitle = f.Musics().WorkTitle();
                return new WorkTitle(workTitle.ISWC, workTitle.Title, workTitle.LanguageCode, workTitle.IsOriginal);
            });
    
    internal static Faker<WorkTitle> GenerateWorkTitles2
        => new Faker<WorkTitle>()
            .RuleFor(
                property: u => u.ISWC,
                setter: (f, _) => f.Musics().WorkTitle().ISWC)
            .RuleFor(
                property: u => u.Title,
                setter: (f, _) => f.Musics().WorkTitle().Title)
            .RuleFor(
                property: u => u.LanguageCode,
                setter: (f, _) => f.Musics().WorkTitle().LanguageCode)
            .RuleFor(
                property: u => u.IsOriginal,
                setter: (f, _) => f.Musics().WorkTitle().IsOriginal);
    
    internal static Faker<InterestedParty> GenerateInterestedParties
        => new Faker<InterestedParty>()
            .CustomInstantiator(f =>
            {
                var ip = f.Musics().IPI();
                var ip1 = new IPI(ip.BaseNumber, ip.NameNumber, ip.Name);
                
                var society = f.Musics().Society();
                var society1 = new Society(society.Code, society.Name, society.Location, society.Region);
                return new InterestedParty(ip1, [ip1], ip1.Name, [society1]);
            });
    
    internal static Faker<InterestedParty> GenerateInterestedParties2
        => new Faker<InterestedParty>()
            .RuleFor(
                property: u => u.IPIBaseNumber,
                setter: (f, _) => new IPI(f.Musics().IPI().BaseNumber, f.Musics().IPI().NameNumber, f.Musics().IPI().Name))
            .RuleFor(
                property: u => u.IPINameNumbers,
                setter: (f, _) =>
                [
                    new(
                        f.Musics().IPI().BaseNumber,
                        f.Musics().IPI().NameNumber, 
                        f.Musics().IPI().Name)
                ] )
            .RuleFor(
                property: u => u.Name,
                setter: (f, _) => f.Musics().IPI().Name)
            .RuleFor(
                property: u => u.Societies,
                setter: (f, _) =>
                [
                    new(
                        f.Musics().Society().Code, 
                        f.Musics().Society().Name, 
                        f.Musics().Society().Location,
                        f.Musics().Society().Region)
                ]);
    
    internal static Faker<Contributor> GenerateContributors
        => new Faker<Contributor>()
            .CustomInstantiator(f =>
            {
                var ip = f.Musics().IPI();
                var ip1 = new IPI(ip.BaseNumber, ip.NameNumber, ip.Name);
                
                var society = f.Musics().Society();
                var society1 = new Society(society.Code, society.Name, society.Location, society.Region);

                var interestedParty = new InterestedParty(ip1, [ip1], ip1.Name, [society1]);
                
                var role = f.Musics().Role();
                var role1 = new Role(role.Code, role.Description);
                
                return new Contributor(interestedParty, role1, f.Random.Double(0, 100));
            });

    internal static Faker<Contributor> GenerateContributors2
        => new Faker<Contributor>()
            .RuleFor(
                property: u => u.InterestedParty,
                setter: (f, _) =>
                    new InterestedParty(
                        new IPI(f.Musics().IPI().BaseNumber, f.Musics().IPI().NameNumber, f.Musics().IPI().Name),
                        [new IPI(f.Musics().IPI().BaseNumber, f.Musics().IPI().NameNumber, f.Musics().IPI().Name)],
                        f.Musics().IPI().Name,
                        [
                            new Society(f.Musics().Society().Code, f.Musics().Society().Name,
                                f.Musics().Society().Location, f.Musics().Society().Region)
                        ]))
            .RuleFor(
                property: u => u.Role,
                setter: (f, _) => new Role(f.Musics().Role().Code, f.Musics().Role().Description))
            .RuleFor(
                property: u => u.Share,
                setter: (f, _) => f.Random.Double(0, 100));
    
    
    internal static Faker<MusicalWork> GenerateMusicalWorks
        => new Faker<MusicalWork>()
            .CustomInstantiator(f =>
            {
                var ip = f.Musics().IPI();
                var ip1 = new IPI(ip.BaseNumber, ip.NameNumber, ip.Name);
                
                var society = f.Musics().Society();
                var society1 = new Society(society.Code, society.Name, society.Location, society.Region);

                var interestedParty = new InterestedParty(ip1, [ip1], ip1.Name, [society1]);
                
                var role = f.Musics().Role();
                var role1 = new Role(role.Code, role.Description);
                
                var contributor = new Contributor(interestedParty, role1, f.Random.Double(0, 100));
                
                var workTitle = f.Musics().WorkTitle();
                var workTitle1 = new WorkTitle(workTitle.ISWC, workTitle.Title, workTitle.LanguageCode, workTitle.IsOriginal);
                
                var genre = f.Musics().Genre();
                var genre1 = new Genre(genre.Code, genre.Name);
                
                return new MusicalWork(workTitle1, genre1, f.Random.Double(0, 100), [contributor]);
            });
}