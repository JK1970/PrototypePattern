namespace PrototypePattern
{
    public abstract class FileComponent
    {
        public int Position { get; set; }

        public FileComponent()
        {

        }
        public FileComponent(FileComponent fileComponent)
        {
            Position = fileComponent.Position;
        }

        public abstract FileComponent Clone();
    }
}