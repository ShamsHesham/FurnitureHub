using FurnitureStore.DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.DAL.Context
{
    public class FurnitureDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> cartItems { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> productCategories { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<ShoppingCart> shoppingCarts { get; set; }
        public DbSet<Customers> customer {  get; set; }


        public FurnitureDbContext(DbContextOptions<FurnitureDbContext> options) : base(options)
        {

        }

        public FurnitureDbContext()
        {



        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
        new Category()
        {
            Id = 1,
            Name = "Sofas",
            Image = "sofas.jpg",
            DateofCreation = DateTime.Now,
            Products = new List<Product>()
        },
        new Category()
        {
            Id = 2,
            Name = "Beds",
            Image = "beds.jpg",
            DateofCreation = DateTime.Now,
            Products = new List<Product>()
        },
        new Category()
        {
            Id = 3,
            Name = "Chairs",
            Image = "chairs.jpg",
            DateofCreation = DateTime.Now,
            Products = new List<Product>()
        },
        new Category()
        {
            Id = 4,
            Name = "Tables",
            Image = "tables.jpg",
            DateofCreation = DateTime.Now,
            Products = new List<Product>()
        },
        new Category()
        {
            Id = 5,
            Name = "Dining",
            Image = "dining.jpg",
            DateofCreation = DateTime.Now,
            Products = new List<Product>()
        },
        new Category()
        {
            Id = 6,
            Name = "Dressing",
            Image = "dressing.jpg",
            DateofCreation = DateTime.Now,
            Products = new List<Product>()
        });

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Modern Brown Sofa",
                    ImageURL = "sofa_with_two_seats.jpg",
                    Description = "Sofa bed with two seats and mechanism",
                    Price = 20000,
                    DateofCreation = DateTime.Now,
                    CategoryID = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "Modern Green bed",
                    ImageURL = "greenbed.jpg",
                    Description = "Modern cushioned bed- 120x195cm",
                    Price = 50000,
                    DateofCreation = DateTime.Now,
                    CategoryID = 2
                },
                new Product()
                {
                    Id = 3,
                    Name = "Modern Orange Chair",
                    ImageURL = "orangechair.jpg",
                    Description = "Modern cushioned Chair- 80x90 cm",
                    Price = 10000,
                    DateofCreation = DateTime.Now,
                    CategoryID = 3
                },
                new Product()
                {
                    Id = 4,
                    Name = "Modern Tables",
                    ImageURL = "3tables.jpg",
                    Description = "3 Sized wooden tables",
                    Price = 18000,
                    DateofCreation = DateTime.Now,
                    CategoryID = 4
                },
                new Product()
                {
                    Id = 5,
                    Name = "Modern Dining Table",
                    ImageURL = "diningtable.jpg",
                    Description = "Rounded Dining table with 3 seats",
                    Price = 45000,
                    DateofCreation = DateTime.Now,
                    CategoryID = 5
                },
                new Product()
                {
                    Id = 6,
                    Name = "Modern Wardrobe",
                    ImageURL = "wardrobe.jpg",
                    Description = "White Wardrobe-240×210 CM - 3 Doors, 2 Drawers",
                    Price = 60000,
                    DateofCreation = DateTime.Now,
                    CategoryID = 6
                });





            modelBuilder.Entity<Order>()
               .HasOne(o => o.Customer)
               .WithMany(c => c.Orders)
               .HasForeignKey(o => o.CustomerID)
               .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            // Configure one-to-many relationship between Order and OrderItem
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderID)
                .OnDelete(DeleteBehavior.Restrict); // Allow cascade delete

            // Configure one-to-many relationship between Product and OrderItem
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductItemID)
                .OnDelete(DeleteBehavior.Restrict); //


            base.OnModelCreating(modelBuilder);


            

            


        }
    }
}
