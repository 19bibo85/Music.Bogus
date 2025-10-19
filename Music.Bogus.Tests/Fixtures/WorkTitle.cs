namespace Music.Bogus.Tests.Fixtures;

internal sealed record WorkTitle
{
    public WorkTitle()
    {
        
    }

    internal WorkTitle(string? iswc, string? title, string? languageCode, bool? isOriginal)
    {
        ISWC = iswc;
        Title = title;
        LanguageCode = languageCode;
        IsOriginal = isOriginal;
    }
    
    internal string? ISWC { set; get; }
    internal string? Title { set; get; }
    internal string? LanguageCode { set; get; }
    internal bool? IsOriginal { set; get; }
}