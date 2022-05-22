using LogisticHelper.Models;
using Microsoft.EntityFrameworkCore;

namespace LogisticHelper.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Uzytkownik> Uzytkowniks { get; set; }
    }
}
