using PrototypePattern.Models;

namespace PrototypePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Image image1 = new()
            {
                Position = 1,
                Source = "/Picture.png"
            };

            Console.WriteLine($"Image1 position: {image1.Position}, source: {image1.Source}");

            Image image2 = (Image)image1.Clone();

            Console.WriteLine($"Image2 position: {image2.Position}, source: {image2.Source}");
        }
    }
}

