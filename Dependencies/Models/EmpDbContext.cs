using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Dependencies.Models
{
    public class EmpDbContext:DbContext
    {

        public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options)
        { 
        
        }  
        public DbSet<Emp> emps { get; set; }

    }
}
