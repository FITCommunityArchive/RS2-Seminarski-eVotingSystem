using System.Collections.Generic;

namespace eVotingSystem.DAL.IServices
{
    public interface IBaseCRUDService<
        TEntity,
        TEntityDTO,
        TSearchObject,
        TEntityInsertRequest,
        TEntityUpdateRequest
        >
        : IBaseREADService<
            TEntity,
            TEntityDTO,
            TSearchObject
            >
        where TEntity : class, new()
        where TEntityDTO : class, new()
        where TSearchObject : class, new()
        where TEntityInsertRequest : class, new()
        where TEntityUpdateRequest : class
    {
        TEntityDTO Insert(TEntityInsertRequest request);
        IEnumerable<TEntityDTO> InsertRange(IEnumerable<TEntityInsertRequest> requests);
        TEntityDTO Update(int id, TEntityUpdateRequest request);
        IEnumerable<TEntityDTO> UpdateRange(List<int> ids, List<TEntityUpdateRequest> requests);
        void Delete(object id);
        void DeleteRange(IEnumerable<object> ids);
    }
}
