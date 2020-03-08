using System;


namespace eVotingSystem.CORE.Models
{
    public class Message : IEntity
    {
        public int Id { get; set; }
        public int? SenderId { get; set; }
        public User Sender { get; set; }
        public int RecieverId { get; set; }
        public User Receiver { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public DateTime TimeOfSending { get; set; }
        public int? PictureId { get; set; }
        public File Picture { get; set; }

        public bool IsDeleted { get; set ; }
    }
}
