using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using EST.Mp.Entities.Concrete;

namespace EST.Mp.DataAccess.Concrete.EntityFramework
{
    public class MpContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Mp;Integrated Security=True");
        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Articles> Articles { get; set; }
        


    }
}
