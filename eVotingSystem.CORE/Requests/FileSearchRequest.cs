using System;
using System.Collections.Generic;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class FileSearchRequest
    {
        public int Id { get; set; }

        public string Path { get; set; }

        public string Extension { get; set; }

        public string Name { get; set; }

    }
}
