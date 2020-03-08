namespace eVotingSystem.CORE.Models
{
    public class File:IEntity
    {
        public int Id { get; set; }

        public string Path { get; set; }

        public string Extension { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }
    }
}