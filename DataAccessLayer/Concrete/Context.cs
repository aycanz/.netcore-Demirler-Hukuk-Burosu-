﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Metadata;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =  ip\\MSSQLSERVER2019; Initial Catalog = Db_Demirler5;user=;password=;TrustServerCertificate=True");
        }


         public DbSet<Yayınlar> yayınlar { get; set; }
        public DbSet<Blog> blogs { get; set; }

    }
}
 
