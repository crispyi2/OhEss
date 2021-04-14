using Microsoft.EntityFrameworkCore;
using OhEss.Models;

namespace OhEss.Data
{
    public class AccountData : DbContext
    {
        public AccountData (DbContextOptions<AccountData> options)
            : base(options)
        {
        }

		public DbSet<Account> Account { get; set; }
    }
}