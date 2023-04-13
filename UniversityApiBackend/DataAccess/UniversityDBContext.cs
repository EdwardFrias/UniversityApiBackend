using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options) 
        {

        }

        //TO-DO: Add DbSets(Tables of our data base)
        public DbSet<User>? Users { get; set; }
        public DbSet<Courses> Courses { get; set; }
    }
}
