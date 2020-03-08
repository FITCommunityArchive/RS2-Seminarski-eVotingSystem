using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalityController : BaseController<
        Nationality,
        NationalityDTO,
        NationalitySearchRequest,
        NationalityRequest,
        NationalityRequest
        >
    {
        public NationalityController(INationalityService Service) :
            base(Service)
        {
        }
    }
}