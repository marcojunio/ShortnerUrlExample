namespace ShortnerUrl;

public class ShortUrl
{
    public ShortUrl()
    {
        Id = Guid.NewGuid().ToString();
        Created = DateTime.Now;
    }

    public string Id { get; }
    public DateTime Created { get; }
    public string? Token { get; set; }
    public string Url { get; set; }
    public string ShortnerUrl { get; set; }
    public bool Clicked { get; set; }
}