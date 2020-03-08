using System;
using System.Collections.Generic;
using System.Text;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
namespace eVotingSystem.DAL.IServices
{
    public interface IUserService :
        IBaseCRUDService<
            User,
           UserDTO,
           UserSearchRequest,
           UserRequest,
           UserRequest
            >
    {
        UserAuthDTO Authenticate(string username, string password);

    }
}
