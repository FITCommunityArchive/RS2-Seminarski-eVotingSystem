using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;
using eVotingSystem.DAL.Helpers;
using System.Linq;
namespace eVotingSystem.DAL.Services
{
    public class UserService :
        BaseCRUDService<
             User,
             UserDTO,
             UserSearchRequest,
             UserRequest,
             UserRequest
            >
        , IUserService
    {
        public UserService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
        public UserAuthDTO Authenticate(string cardId, string password)
        {
            User user = _dbContext.Users
                .Where(x => x.CardId == cardId)
                .FirstOrDefault();

            if (user == null)
            {
                return null;
            }

            password = Crypto.GetHashedPassword(password, user.PasswordSalt);

            if (user.PasswordHash != password)
            {
                return null;
            }

            var userDTO = _mapper.Map<UserAuthDTO>(user);

            return userDTO;
        }

        public override UserDTO Update(int id,UserRequest request)
        {
            var item = DbSet
                        .Where(x => x.Id.Equals(id))
                        .FirstOrDefault();
            if (item == null)
            {
                return _mapper.Map<UserDTO>(request);
            }

            item = _mapper.Map(request, item);
            item.Id = id;
            item.PasswordHash = Crypto.GetHashedPassword(request.Password, item.PasswordSalt);

            _dbContext.SaveChanges();

            var itemDTO = _mapper.Map<UserDTO>(item);

            return itemDTO;
        }
        public override UserDTO Insert(UserRequest request)
        {
            var model = _mapper.Map<User>(request);

            if (string.IsNullOrEmpty(request.CardId) || string.IsNullOrEmpty(request.Password) || string.IsNullOrEmpty(request.PasswordConfirmed))
            {
                throw new UserException("Username or Password or PasswordConfirm is empty");
            }

            if (request.Password != request.PasswordConfirmed)
            {
                throw new UserException("PasswordsNotMatching");
            }

            model.PasswordSalt = Crypto.GenerateSalt();
            model.PasswordHash = Crypto.GetHashedPassword(request.Password, model.PasswordSalt);

            var result = _dbContext.Users.Add(model).Entity;
            _dbContext.SaveChanges();

            return _mapper.Map<UserDTO>(result);
        }
    }
}
