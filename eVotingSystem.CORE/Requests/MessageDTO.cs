﻿using System;


namespace eVotingSystem.CORE.Requests
{
    public class MessageDTO 
    {
        public int Id { get; set; }
        public int? SenderId { get; set; }
        public UserDTO Sender { get; set; }
        public int RecieverId { get; set; }
        public UserDTO Receiver { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public DateTime TimeOfSending { get; set; }
        public int? PictureId { get; set; }
        public FileDTO Picture { get; set; }

    }
}
