
using eVotingSystem.DAL.Helpers;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<
        TEntity,
        TEntityDTO,
        TSearchObject,
        TEntityInsertRequest,
        TEntityUpdateRequest
        > : ControllerBase
        where TEntity : class, new()
        where TEntityDTO : class, new()
        where TSearchObject : class, new()
        where TEntityInsertRequest : class, new()
        where TEntityUpdateRequest : class
    {
        private IBaseCRUDService<
            TEntity,
            TEntityDTO,
            TSearchObject,
            TEntityInsertRequest,
            TEntityUpdateRequest
            > _baseCRUDService;

        public BaseController(IBaseCRUDService<
            TEntity,
            TEntityDTO,
            TSearchObject,
            TEntityInsertRequest,
            TEntityUpdateRequest> baseCRUDService)
        {
            _baseCRUDService = baseCRUDService;
        }

        // GET: api/Base
        [HttpGet]
        public virtual IEnumerable<TEntityDTO> Get([FromQuery]TSearchObject searchObject = null, [FromQuery]Pagination pagination = null)
        {
            return _baseCRUDService.Get(searchObject);
        }

        // GET: api/Base/5
        [HttpGet("{id}")]
        public virtual TEntityDTO Get(int id)
        {
            return _baseCRUDService.GetById(id);
        }

        // POST: api/Base
        [HttpPost]
        public virtual TEntityDTO Post([FromBody] TEntityInsertRequest request)
        {
            return _baseCRUDService.Insert(request);
        }

        // PUT: api/Base/5
        [HttpPut("{id}")]
        public virtual TEntityDTO Put(int id, [FromBody] TEntityUpdateRequest request)
        {
            return _baseCRUDService.Update(id, request);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public virtual void Delete(int id)
        {
            _baseCRUDService.Delete(id);
        }
    }
}
