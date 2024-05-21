using Microsoft.EntityFrameworkCore;
using STUDENT_MVC_PROJECT.Models.Entities;

namespace STUDENT_MVC_PROJECT.DataBaseConnect
{
    public class ApplicationDbContext : DbContext
    {
        //create a constructor using ctor then press tab

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //to capture the details from the view using crud operation create a property here for the database
        //table to be created
        public DbSet<Student> Students { get; set; }   // coming from the entities



    }
}
