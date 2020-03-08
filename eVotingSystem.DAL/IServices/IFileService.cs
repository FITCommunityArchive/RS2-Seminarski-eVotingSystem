using System;
using System.Collections.Generic;
using System.Text;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
namespace eVotingSystem.DAL.IServices
{
    public interface IFileService :
        IBaseCRUDService<
            File,
            FileDTO,
            FileSearchRequest,
            FileRequest,
            FileRequest
            >
    {
    }
}
