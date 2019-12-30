using DataContextLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataContextLayer.DataContext
{
    public class EFDataContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }

        public DbSet<Designation> Designations { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=FMF-HO-PROG4;Initial Catalog=SIG;Integrated Security=False;Persist Security Info=False;User ID=sa;Password=finansia");
        }
    }
}
