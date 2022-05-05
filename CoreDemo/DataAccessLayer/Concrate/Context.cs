using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
    //10.ve 11. ders
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-G2007Q5;Initial Catalog=CoreBlogDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseSqlServer("server = DESKTOP-G2007Q5\\MSSQLSERVER01;database=CoreBlogDB;integrated security=true;");

            // Scaffold - Context "Data Source=DESKTOP-G2007Q5; Initial Catalog =CoreBlogDb;integrated security=true; " Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
