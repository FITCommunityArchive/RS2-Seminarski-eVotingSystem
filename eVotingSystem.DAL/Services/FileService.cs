using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;
using eVotingSystem.CORE.Helpers;
using Mapper = AutoMapper.Mapper;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace eVotingSystem.DAL.Services
{
    public class FileService :
        BaseCRUDService<
            File,
            FileDTO,
            FileSearchRequest,
            FileRequest,
            FileRequest
            >
        , IFileService
    {
        public FileService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    }
    //public virtual FileDTO Insert(FileRequest request)
    //{
    //    var item = _mapper.Map<File>(request);

    //    var resultItem = DbSet.Add(item).Entity;

    //    _dbContext.SaveChanges();

    //    var itemDTO = _mapper.Map<TEntityDTO>(resultItem);

    //    return itemDTO;
    //}
}
