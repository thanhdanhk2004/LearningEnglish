using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Domain.EntitiesUser
{
    public class Account
    {
        public Guid AccountId { get; set; }
        public string Username { get; private set; }
        public string PasswordHash { get; private set; }
        public Guid UserId { get; private set; }
        public User User { get; private set; }
        public Account(string username, string PasswordHash)
        {
            if (username == null) throw new ArgumentNullException("Username not allow null");
            if (string.IsNullOrWhiteSpace(PasswordHash))
                throw new ArgumentNullException("Password incorrect");
            AccountId = Guid.NewGuid();
            Username = username;
            PasswordHash = PasswordHash;
        }
    }
}
