using MTechWebApi.Models;

namespace MTechWebApi.Services
{
    public class UserService
    {
        private readonly List<User> _users = new List<User> 
        {
            new User { Id = 1, Name = "Juan", Email = "juan@mail.com" },
            new User { Id = 2, Name = "Manuel", Email = "manuel@mail.com" },
            new User { Id = 3, Name = "Pablo", Email = "pablo@mail.com" },
            new User { Id = 4, Name = "Pedro", Email = "pedro@mail.com" },
            new User { Id = 5, Name = "Marco", Email = "marco@mail.com" }
        };

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }   
    }
}