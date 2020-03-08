using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class MessageRequest
    {
        public int Id { get; set; }
        public int? SenderId { get; set; }
        public int RecieverId { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public DateTime TimeOfSending { get; set; }
        public int? PictureId { get; set; }

    }
}
