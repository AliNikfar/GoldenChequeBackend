using GoldenCheque.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldenCheque.Models.DAL
{
    public class dbContext : DbContext
    {

        public dbContext(DbContextOptions options):base(options)
        {

        }
        public dbContext()
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BaseInfo> BaseInfos { get; set; }
        public DbSet<Cheque> Cheques { get; set; }
        public DbSet<Factor> Factors { get; set; }
        public DbSet<FactorObjects> FactorObjects { get; set; }
        public DbSet<Ghest> Ghests { get; set; }
        public DbSet<Objectt> Objects { get; set; }
        public DbSet<Shobe> Shobes { get; set; }
        public DbSet<Units> Units { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Initial Catalog=GoldenChequeWeb;Integrated Security = true");
                base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ولیدیشن های دیتا
            //modelBuilder.Entity<Person>().Property(c => c.Name).HasMaxLength(50).IsRequired();
            //modelBuilder.Entity<Person>().Property(c => c.Family).HasMaxLength(50).IsRequired();
            ////شرط پیش فرض برای لود دیتا
            //modelBuilder.Entity<Factor>().HasQueryFilter(p => p.Visable == true);
            ////modelBuilder.Entity<Person>().HasQueryFilter(c => c. == false);
            //base.OnModelCreating(modelBuilder);

        }
    }
}
