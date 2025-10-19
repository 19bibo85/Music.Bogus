## Music.Bogus

Bogus extension for Music, it provides an easy way to generate fake IPI numbers, Societies, Genres, etc.

## Usage

```csharp

var faker = new Faker<IPI>()
    .RuleFor(
        property: u => u.BaseNumber,
        setter: (f, _) => f.Musics().IPI().BaseNumber) // M-669450910-9
    .RuleFor(
        property: u => u.NameNumber,
        setter: (f, _) => f.Musics().IPI().NameNumber) // 69055491803
    .RuleFor(
        property: u => u.Name,
        setter: (f, _) => f.Musics().IPI().Name); // Enya

var ipi = faker.Generate();
```

## Json files

Files are located in the `data.zip` file in the `Music.Bogus` project.
