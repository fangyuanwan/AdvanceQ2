
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using taskConsume.Models;

namespace taskConsume.Models
{
    public class TaskDBContext : DbContext
    {
        public TaskDBContext(DbContextOptions<TaskDBContext> options)
            : base(options)
        {
        }
        public DbSet<task> Tasks { get; set; }
    }
}