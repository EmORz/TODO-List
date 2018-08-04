using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace TODOList.Models
{
    public class TaskDbContext : DbContext
    {
        public virtual DbSet<Task> Tasks { get; set; }
        public TaskDbContext()
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=todo;user=root;");
        }
    }
}
