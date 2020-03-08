using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class NationalityRequest
    {
        public int Id { get; set; }
        [MinLength(3, ErrorMessage = nameof(Resources.Resource.MinLengthField3))]
        public string Name { get; set; }
    }
}
