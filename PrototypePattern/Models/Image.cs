namespace PrototypePattern.Models
{
    public class Image : FileComponent
    {
        public string? Source { get; set; }

        public Image()
        {

        }
        public Image(Image image) : base(image)
        {
            Source = image.Source;
        }

        public override FileComponent Clone()
        {
            return new Image(this);
        }
    }
}