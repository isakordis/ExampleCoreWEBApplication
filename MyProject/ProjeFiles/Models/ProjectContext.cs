using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjeFiles.Models;

namespace ProjeFiles.Models
{
    public class ProjectContext:DbContext

    {
        public ProjectContext(DbContextOptions<ProjectContext> options):base(options)
        {
                
        }

        public DbSet<Users> users { get; set; }
        public DbSet<Product> products { get; set; }
        

    }
}
