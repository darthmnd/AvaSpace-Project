namespace AvaSpace.Domain.Entities
{
    public class Midia : BaseEntity
    {
        public Midia()
        {
            MidiaType = new MidiaType();
        }
        public MidiaType MidiaType { get; set; }
        public string Path { get; set; }
    }
}
