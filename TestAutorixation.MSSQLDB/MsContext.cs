using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace TestAutorixation.MSSQLDB
{
    public class MsContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connetionString());
        }

        private string connetionString()
        {
            return @"Server=192.168.10.134; database=MyTestAutorixationAhtyamov; " +
                  "User id=stud; Password=stud";
        }
    }
}
