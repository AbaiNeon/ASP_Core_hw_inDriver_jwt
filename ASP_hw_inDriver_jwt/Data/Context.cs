using ASP_hw_inDriver_jwt.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_hw_inDriver_jwt.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        //public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var user1 = new User
            {
                Id = 1,
                Login = "Abai",
                Name = "Абай",
                Password = "123",
                PhoneNumber = "911"
            };

            //var user2 = new User
            //{
            //    Id = 2,
            //    Login = "Marat",
            //    Name = "Марат",
            //    Password = "123",
            //    PhoneNumber = "112"
            //};

            var order = new Order
            {
                Id = 1,
                ClientId = user1.Id,
                PointA = "Брусиловского 5",
                PointB = "КА ШАГ",
                Price = 700,
                ExecutionStatus = false
            };

            modelBuilder.Entity<User>().HasData(user1);
            modelBuilder.Entity<Order>().HasData(order);


            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
