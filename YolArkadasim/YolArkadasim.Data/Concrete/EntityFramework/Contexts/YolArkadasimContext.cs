using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using YolArkadasim.Data.Concrete.EntityFramework.Mappings;
using YolArkadasim.Entities.Concrete;

namespace YolArkadasim.Data.Concrete.EntityFramework.Contexts
{
    public class YolArkadasimContext:IdentityDbContext<User,Role,int,UserClaim,UserRole,UserLogin,RoleClaim,UserToken>
    {
        public DbSet<Journey> Journeys { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        
        public DbSet<City> Cities { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //        @"Server=DESKTOP-2GLKQT8;Database=YolArkadasim;Trusted_Connection=True;Connect Timeout=30;MultipleActiveResultSets=True;");
        //}


        public YolArkadasimContext(DbContextOptions<YolArkadasimContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) //Mapping işlemlerini DbContext içerisinde konfigürasyon sınıfı olarak çağırıyoruz.
        {
            modelBuilder.ApplyConfiguration(new JourneyMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new RoleClaimMap());
            modelBuilder.ApplyConfiguration(new UserClaimMap());
            modelBuilder.ApplyConfiguration(new UserLoginMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());
            modelBuilder.ApplyConfiguration(new UserTokenMap());
        }
    }
}
