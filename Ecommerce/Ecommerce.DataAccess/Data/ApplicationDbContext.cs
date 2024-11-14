using Ecommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = 1, Name = "Psychology", DisplayOrder = 1 },
                 new Category { Id = 2, Name = "Detective", DisplayOrder = 2 },
                 new Category { Id = 3, Name = "Philosophy", DisplayOrder = 3 }
                 );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Noman Models",
                    StreetAddress = "144 Doran Street",
                    City = "Dhaka City",
                    PostalCode = "33578",
                    State = "Dhaka",
                    PhoneNumber = "55568888"
                },
                new Company
                {
                    Id = 2,
                    Name = "National Books",
                    StreetAddress = "13 AB St",
                    City = "Rajshahi City",
                    PostalCode = "1553",
                    State = "Rajshahi",
                    PhoneNumber = "55757899"
                },
                new Company
                {
                    Id = 3,
                    Name = "Vivid Production",
                    StreetAddress = "999 Main St",
                    City = "Dora",
                    PostalCode = "55633",
                    State = "Rangpur",
                    PhoneNumber = "65559944"
                }
                );


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Laws of Human Nature",
                    Author = "Robert Greene",
                    Description = "The Laws of Human Nature by Robert Greene is a comprehensive exploration of human behavior, psychology, and the intricacies of social dynamics. In this book, Greene delves into the complexities of human nature, drawing from history, philosophy, and psychology to uncover the underlying motivations that drive people's actions",
                    ISBN = "SWD9999001",
                    ListPrice = 9,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Mastery",
                    Author = "Robert Greene",
                    Description = "Mastery is a book by Robert Greene, first published in 2012, that explores the process of achieving mastery in any field. Greene identifies mastery as a lifelong pursuit of developing exceptional skills and knowledge, drawing from the lives and careers of historical figures, thinkers, and artists who achieved the highest level of mastery in their respective domains.",
                    ISBN = "CAW777777701",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "On the Shortness of Life",
                    Author = "De Brevitate Vitae",
                    Description = "On the Shortness of Life is a classic philosophical essay by the Roman Stoic philosopher Seneca. Written around 49 AD, it reflects Seneca's thoughts on time, life, and how humans often squander the precious time they have. The essay is a powerful meditation on the nature of life, urging readers to live purposefully and use their time wisely.",
                    ISBN = "RITO5555501",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 4,
                    Title = "The Case-Book of Sherlock Holmes",
                    Author = "Sir Arthur Conan Doyle",
                    Description = "The Case-Book of Sherlock Holmes is a collection of twelve short stories by Sir Arthur Conan Doyle, first published in 1927. It is one of the later volumes in the Sherlock Holmes series, following The Return of Sherlock Holmes and His Last Bow. The stories feature the iconic detective Sherlock Holmes and his trusted companion, Dr. John Watson, solving a variety of complex and intriguing cases.",
                    ISBN = "WS3333333301",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 5,
                    Title = "The past is a foreign country",
                    Author = "L.P. Hartley",
                    Description = "The past is a foreign country speaks to the distance we feel from our own history, and how memory, time, and perspective shape our understanding of who we were. It reminds us that while the past is part of us, it remains elusive, often as strange and distant as a place we can never fully return to or truly understand. The phrase encapsulates the bittersweet nature of memory: we can only visit it, not live in it.",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 6,
                    Title = "The Republic",
                    Author = "Plato",
                    Description = "The Republic is a philosophical work written by Plato, one of the most influential thinkers in Western philosophy, around 380 BCE. The dialogue is written in the form of a conversation, primarily between Socrates and various other characters, and it addresses justice, the ideal state, the nature of the human soul, and the pursuit of truth.",
                    ISBN = "FOT000000001",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );
        }
    }
}
