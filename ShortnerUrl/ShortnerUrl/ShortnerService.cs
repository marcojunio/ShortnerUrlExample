namespace ShortnerUrl;

public class ShortnerService
{
    public string? Token { get; set; }
    private ShortUrl _shortUrl = new();

    private void GenerateToken()
    {
        string urlsafe = string.Empty;

        Enumerable.Range(48, 75)
            .Where(i => i < 58 || i > 64 && i < 91 || i > 96)
            .OrderBy(o => new Random().Next())
            .ToList()
            .ForEach(i => urlsafe += Convert.ToChar(i));
        Token = urlsafe.Substring(new Random().Next(0, urlsafe.Length), new Random().Next(2, 6));
    }

    public ShortnerService(string url)
    {
        GenerateToken();
        
        _shortUrl = new()
        {
            Token = Token,
            Url = url,
            ShortnerUrl = Settings.BASE_URL + Token,
        };
    }


    public ShortUrl GetShortGenerated()
    {
        return _shortUrl;
    }
}