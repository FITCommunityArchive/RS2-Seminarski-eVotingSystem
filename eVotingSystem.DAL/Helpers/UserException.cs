using System;

namespace eVotingSystem.DAL.Helpers
{
    public class UserException : Exception
    {
        public UserException(string message) :
            base(message)
        {
        }
    }
}
