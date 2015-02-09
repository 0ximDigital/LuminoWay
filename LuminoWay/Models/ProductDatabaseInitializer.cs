using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Diagnostics;

namespace LuminoWay.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>      // Use DropCreateDatabaseAlways da kod svakog pokretanja napravi bazu
    {
        protected override void Seed(ProductContext context)
        {
            Debug.WriteLine("Initial seeding of a Product DataBase");
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>{
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "LED Boards"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "LED Diodes"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "LED Strips"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "LED Bulbs"
                },
            };
            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>{
                new Product
                {
                    ProductID = 101,            // First digit represents product category
                    ProductName = "Interactive LED Board",
                    Description = "Led Board that illuminates as an object howers above it !", 
                    ImagePath="Images/LedBoards/InteractiveLedBoard.jpg",
                    UnitPrice = 45.00,
                    CategoryID = 1
                },

                new Product
                {
                    ProductID = 201,            
                    ProductName = "Red LED Diode",
                    Description = "Diffused LED Diode, 5mm diameter.", 
                    ImagePath="Images/LedDiodes/red_led.jpg",
                    UnitPrice = 1.50,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 202,            
                    ProductName = "Green LED Diode",
                    Description = "Diffused LED Diode, 5mm diameter.", 
                    ImagePath="Images/LedDiodes/green_led.jpg",
                    UnitPrice = 1.50,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 203,            
                    ProductName = "Blue LED Diode",
                    Description = "Diffused LED Diode, 5mm diameter.", 
                    ImagePath="Images/LedDiodes/blue_led.jpg",
                    UnitPrice = 1.78,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 204,            
                    ProductName = "Yellow LED Diode",
                    Description = "Diffused LED Diode, 5mm diameter.", 
                    ImagePath="Images/LedDiodes/yellow_led.jpg",
                    UnitPrice = 1.50,
                    CategoryID = 2
                },

                new Product
                {
                    ProductID = 301,            
                    ProductName = "Red LED Strip",
                    Description = "Five meter long LED strip. Ideal for parties, raves, Christmas, weddings Lighting, event, show exhibition, home decoration, hotels, clubs, disco bars, TV studios, shopping malls, boutique atmosphere lighting.", 
                    ImagePath="Images/LedStrips/red_led_strip.jpg",
                    UnitPrice = 30.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 302,            
                    ProductName = "Green LED Strip",
                    Description = "Five meter long LED strip. Ideal for parties, raves, Christmas, weddings Lighting, event, show exhibition, home decoration, hotels, clubs, disco bars, TV studios, shopping malls, boutique atmosphere lighting.", 
                    ImagePath="Images/LedStrips/green_led_strip.jpg",
                    UnitPrice = 30.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 303,            
                    ProductName = "Blue LED Strip",
                    Description = "Five meter long LED strip. Ideal for parties, raves, Christmas, weddings Lighting, event, show exhibition, home decoration, hotels, clubs, disco bars, TV studios, shopping malls, boutique atmosphere lighting.", 
                    ImagePath="Images/LedStrips/blue_led_strip.jpg",
                    UnitPrice = 30.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 304,            
                    ProductName = "Multicolor LED Strip",
                    Description = "Five meter long LED strip. Ideal for parties, raves, Christmas, weddings Lighting, event, show exhibition, home decoration, hotels, clubs, disco bars, TV studios, shopping malls, boutique atmosphere lighting.", 
                    ImagePath="Images/LedStrips/rgb_strip.jpg",
                    UnitPrice = 35.00,
                    CategoryID = 3
                },

                new Product
                {
                    ProductID = 401,            
                    ProductName = "RGB LED Bulb",
                    Description = "Input Voltage: AC 100-240V Power Consumption: 3W Service Life: About 20000 Hours Beam Angle: 60 Degrees Lumen: 300LM Material: High Strength Aluminum Shell, Four Lighting Effects: flash, strobe, fade, smooth", 
                    ImagePath="Images/LedBulbs/rgb_led_bulb.JPG",
                    UnitPrice = 8.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 402,            
                    ProductName = "LED Corn Bulb",
                    Description = "Ultra energy efficient replacement of standard lamp. Features low power consumption, no mercury, no UV, infrared or other deleterious radiation. The Light Bulb provide bright and soft light for everyday use. Features up to 30000- 50000 hours service time design, which enough to your daily use ", 
                    ImagePath="Images/LedBulbs/corn_led_bulb.JPG",
                    UnitPrice = 6.00,
                    CategoryID = 4
                }
            };
            return products;
        }
    }

}