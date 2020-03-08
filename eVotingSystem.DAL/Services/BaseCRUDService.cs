using AutoMapper;
using eVotingSystem.DAL.IServices;
using eVotingSystem.CORE.Models;
using eVotingSystem.DAL.EF;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace eVotingSystem.DAL.Services
{
    public class BaseCRUDService<
        TEntity,
        TEntityDTO,
        TSearchObject,
        TEntityInsertRequest,
        TEntityUpdateRequest
        >
        :
        BaseREADService<
            TEntity,
            TEntityDTO,
            TSearchObject
            >,
        IBaseCRUDService<
            TEntity,
            TEntityDTO,
            TSearchObject,
            TEntityInsertRequest,
            TEntityUpdateRequest
        >
        where TEntity : class, IEntity, new()
        where TEntityDTO : class, new()
        where TSearchObject : class, new()
        where TEntityInsertRequest : class, new()
        where TEntityUpdateRequest : class
    {
        protected DbSet<TEntity> DbSet;

        public BaseCRUDService(
            eVotingSystemDbContext dbContext, 
            IMapper mapper
            ) :
            base(dbContext, mapper)
        {
            DbSet = _dbContext.Set<TEntity>();
        }

        public virtual void Delete(object id)
        {
            var item = DbSet
                .Where(x => x.Id.Equals(id))
                .FirstOrDefault();

            if (item == null)
            {
                return;
            }

            item.IsDeleted = true;

            _dbContext.SaveChanges();
        }

        public virtual void DeleteRange(IEnumerable<object> ids)
        {
            foreach (var id in ids)
            {
                Delete(id);
            }
        }

        public virtual TEntityDTO Insert(TEntityInsertRequest request)
        {
            var item = _mapper.Map<TEntity>(request);

            var resultItem = DbSet.Add(item).Entity;

            _dbContext.SaveChanges();

            var itemDTO = _mapper.Map<TEntityDTO>(resultItem);

            return itemDTO;
        }

        public virtual IEnumerable<TEntityDTO> InsertRange(IEnumerable<TEntityInsertRequest> requests)
        {
            var result = new List<TEntityDTO>();

            foreach (var request in requests)
            {
                result.Add(Insert(request));
            }

            return result;
        }

        public virtual TEntityDTO Update(int id, TEntityUpdateRequest request)
        {
            var item = DbSet
                .Where(x => x.Id.Equals(id))
                .FirstOrDefault();

            if (item == null)
            {
                return _mapper.Map<TEntityDTO>(request);
            }

            item = _mapper.Map(request, item);
            item.Id = id;

            _dbContext.SaveChanges();

            var itemDTO = _mapper.Map<TEntityDTO>(item);

            return itemDTO;
        }

        public virtual IEnumerable<TEntityDTO> UpdateRange(List<int> ids, List<TEntityUpdateRequest> requests)
        {
            var result = new List<TEntityDTO>();
            var count = ids.Count();

            for (int i = 0; i < count; i++)
            {
                result.Add(Update(ids[i], requests[i]));
            }

            return result;
        }
    }
}
