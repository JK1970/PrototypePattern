namespace PrototypePattern.Models
{
    public class Paragraph : FileComponent
    {
        public string? Text { get; set; }

        public Paragraph()
        {

        }
        public Paragraph(Paragraph paragraph) : base(paragraph)
        {
            Text = paragraph.Text;
        }

        public override FileComponent Clone()
        {
            return new Paragraph(this);
        }
    }
}