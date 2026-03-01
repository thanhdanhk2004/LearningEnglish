using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Domain.EntitiesUser;
using UserService.Infrastructure.Configuration;

namespace UserService.Infrastructure.Context
{
    public class DBContextUser:DbContext
    {
        public DBContextUser(DbContextOptions<DBContextUser> options) : base(options) { }
        public DBContextUser() { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
        }
    }
}
