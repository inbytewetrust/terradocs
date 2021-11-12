

namespace Core.Domain.Documents
{
    public abstract class Документ
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DocType { get; set; }
    }
}
