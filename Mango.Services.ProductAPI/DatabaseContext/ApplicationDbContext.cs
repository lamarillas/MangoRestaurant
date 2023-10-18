using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Guacamole",
                Price = 60.55,
                Description = "A dip made from mashed avocados; mixed with tomatoes, onions, and spices.",
                ImageUrl = "",
                CategoryName = "Appetizer"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Quesadilla",
                Price = 40.00,
                Description = "A tortilla filled with cheese and sometimes meat or vegetables; cooked until the cheese is melted.",
                ImageUrl = "",
                CategoryName = "Appetizer"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sope",
                Price = 25.90,
                Description = "A traditional Mexican dish; a thick tortilla with pinched sides, topped with meat, beans, lettuce, and salsa..",
                ImageUrl = "",
                CategoryName = "Appetizer"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Nacho",
                Price = 45.50,
                Description = "a popular appetizer; tortilla chips covered with cheese or cheese-based sauce, often served with jalapenos.",
                ImageUrl = "",
                CategoryName = "Appetizer"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Chiles en Nogada",
                Price = 60.00,
                Description = "A dish consisting of poblano chilis filled with picadillo; topped with a walnut-based cream sauce and pomegranate seeds.",
                ImageUrl = "",
                CategoryName = "Appetizer"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Tostada",
                Price = 15.25,
                Description = "A flat or bowl-shaped tortilla that is fried or toasted; often served with beans, meat, and other toppings.",
                ImageUrl = "",
                CategoryName = "Appetizer"
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Horchata",
                Price = 15.99,
                Description = "A refreshing beverage; made from rice, milk, vanilla, and cinnamon.",
                ImageUrl = "",
                CategoryName = "Beverages"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Tequila",
                Price = 40.50,
                Description = "A famous Mexican alcoholic drink; made from the blue agave plant.",
                ImageUrl = "",
                CategoryName = "Beverages"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Mezcal",
                Price = 25.99,
                Description = "Another type of Mexican alcoholic drink; similar to tequila but made from various types of agave.",
                ImageUrl = "",
                CategoryName = "Beverages"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Atole",
                Price = 15.99,
                Description = "A traditional warm drink; made with masa, cinnamon, vanilla, and optional chocolate or fruit flavorings.",
                ImageUrl = "",
                CategoryName = "Beverages"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Pulque",
                Price = 30.50,
                Description = "A traditional Mexican alcoholic beverage; made from the fermented sap of the agave plant.",
                ImageUrl = "",
                CategoryName = "Beverages"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 12,
                Name = "Café de Olla",
                Price = 15.55,
                Description = "A traditional Mexican coffee; brewed with cinnamon and piloncillo (unrefined cane sugar).",
                ImageUrl = "",
                CategoryName = "Beverages"
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 13,
                Name = "Churro",
                Price = 5.90,
                Description = "A fried-dough pastry; coated in sugar and often served with chocolate sauce.",
                ImageUrl = "",
                CategoryName = "Desserts"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 14,
                Name = "Flan",
                Price = 12.50,
                Description = "A sweet custard dessert; often flavored with vanilla and caramel.",
                ImageUrl = "",
                CategoryName = "Desserts"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 15,
                Name = "Tres Leches Cake",
                Price = 25.99,
                Description = "A sponge cake; soaked in three kinds of milk: evaporated milk, condensed milk, and heavy cream.",
                ImageUrl = "",
                CategoryName = "Desserts"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 16,
                Name = "Arroz con Leche",
                Price = 15.99,
                Description = "A Mexican rice pudding; cooked with milk, sugar, cinnamon, and vanilla.",
                ImageUrl = "",
                CategoryName = "Desserts"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 17,
                Name = "Coyotas",
                Price = 12.50,
                Description = "A type of pastry; usually filled with brown sugar and sometimes other sweet fillings.",
                ImageUrl = "",
                CategoryName = "Desserts"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 18,
                Name = "Sopapilla",
                Price = 15.50,
                Description = "A type of fried pastry; served as a dessert and often topped with honey, syrup, or sugar.",
                ImageUrl = "",
                CategoryName = "Desserts"
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 19,
                Name = "Enchilada",
                Price = 25.99,
                Description = "A corn tortilla rolled around a filling and covered with chili pepper sauce; often filled with meat, cheese, beans, or vegetables.",
                ImageUrl = "",
                CategoryName = "Main Courses"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 20,
                Name = "Taco",
                Price = 20.99,
                Description = "A traditional Mexican dish; consists of a folded or rolled tortilla filled with various ingredients such as meat, beans, cheese, and lettuce.",
                ImageUrl = "",
                CategoryName = "Main Courses"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 21,
                Name = "Tamal",
                Price = 25.55,
                Description = "A traditional Mesoamerican dish; made of dough that is steamed in a corn husk and filled with meats, cheeses, or fruits.",
                ImageUrl = "",
                CategoryName = "Main Courses"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 22,
                Name = "Chile Relleno",
                Price = 45.59,
                Description = "A dish made with a stuffed, roasted chili pepper; filling includes cheese, meat or a combination of both.",
                ImageUrl = "",
                CategoryName = "Main Courses"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 23,
                Name = "Barbacoa",
                Price = 55.99,
                Description = "Slow-cooked meats; typically beef, goat, or lamb, often served in tacos or burritos.",
                ImageUrl = "",
                CategoryName = "Main Courses"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 24,
                Name = "Pozole",
                Price = 60.50,
                Description = "A traditional soup or stew; made with hominy, meat, and seasoned with herbs and spices.",
                ImageUrl = "",
                CategoryName = "Main Courses"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 24,
                Name = "Menudo",
                Price = 65.90,
                Description = "A traditional Mexican soup; made with cow's stomach, hominy, and a red chili pepper base.",
                ImageUrl = "",
                CategoryName = "Main Courses"
            });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
