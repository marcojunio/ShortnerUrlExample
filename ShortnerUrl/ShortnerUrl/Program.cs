using System.Reflection;
using ShortnerUrl;

public class Program
{
    public static void Main(string[] args)
    {
        var shortner = new ShortnerService("https://github.com/marcojunio/ShortnerUrlExample");
        var generated = shortner.GetShortGenerated();

        foreach (PropertyInfo property in generated.GetType().GetProperties())
        {
            Console.WriteLine($"{property.Name}: {property.GetValue(generated)}");
        }
    } 
}
