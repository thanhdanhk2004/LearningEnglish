using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Domain.EntitiesUser
{
    public class User
    {
        public Guid UserId { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Avatar { get; private set; }
        public Account Account { get; private set; }
        public User(string name, string email, string avatar)
        {
            UserId = Guid.NewGuid();
            Name = name;
            Email = email;
            Avatar = avatar;
        }
    }
}
