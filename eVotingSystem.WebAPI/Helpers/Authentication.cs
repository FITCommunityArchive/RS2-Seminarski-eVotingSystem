using AutoMapper;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace eVotingSystem.WebAPI.Helpers
{
    public static class Authentication
    {
        public static UserDTO CurrentUser(this HttpContext httpContext)
        {
            var _userService = httpContext.RequestServices.GetRequiredService<IUserService>();
            var _mapper = httpContext.RequestServices.GetRequiredService<IMapper>();

            UserAuthDTO userAuthDTO = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(httpContext.Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];
                userAuthDTO = _userService.Authenticate(username, password);
            }
            catch
            {
                throw new UnauthorizedAccessException("Unauthorized");
            }

            if (userAuthDTO == null)
            {
                throw new UnauthorizedAccessException("Invalid Username or Password");
            }

            return _userService.GetById(userAuthDTO.Id);
        }

    }
}
