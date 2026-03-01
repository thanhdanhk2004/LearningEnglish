using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Domain.EntitiesUser;

namespace UserService.Infrastructure.Configuration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");
            builder.HasKey(a => a.AccountId);

            builder.Property(a => a.Username).IsRequired();
            builder.Property(a => a.PasswordHash).IsRequired();

        }
    }
}
