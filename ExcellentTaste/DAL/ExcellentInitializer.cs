using ExcellentTaste.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ExcellentTaste.DAL
{
    public class ExcellentInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ExcellentContext>
    {//test
        protected override void Seed(ExcellentContext context)
        {
            var Employees = new List<Employee>
            {
                new Employee{EmailAdress="Admin@email.com", Password = "@1234A", FirstName = "Jan", LastName = "Janssen", Role = Role.Administrator},
                new Employee{EmailAdress="Ober@email.com", Password = "@2345B", FirstName = "Bert", LastName = "Bartens", Role = Role.Ober},
                new Employee{EmailAdress="Kok@email.com", Password = "@3456C", FirstName = "Truus", LastName = "Tenten", Role = Role.Kok},
                new Employee{EmailAdress="Barman@email.com", Password = "@4567D", FirstName = "Trien", LastName = "Trientjes", Role = Role.Barman}
            };

            if (context.Employees.Count()==0)
            {
                context.Employees.AddRange(Employees);
                context.SaveChanges();
            }

            var newTables = new List<Table>
            {
                new Table{TableNumber="1"},
                new Table{TableNumber="2"},
                new Table{TableNumber="3"},
                new Table{TableNumber="4"},
                new Table{TableNumber="5"},
                new Table{TableNumber="6"},
                new Table{TableNumber="7"},
                new Table{TableNumber="8"},
                new Table{TableNumber="9"},
                new Table{TableNumber="10"},
                new Table{TableNumber="11"},
                new Table{TableNumber="12"},
                new Table{TableNumber="13"},
                new Table{TableNumber="14"},
                new Table{TableNumber="15"},
                new Table{TableNumber="16"},
            };

            if (context.Tables.Count() == 0)
            {
                context.Tables.AddRange(newTables);
                context.SaveChanges();
            }

            var newCategories = new List<Category>
            {
                new Category
                {
                    CategoryType = "Koude dranken"
                },
                new Category
                {
                    CategoryType = "Warme dranken"
                },
                new Category
                {
                    CategoryType = "Alcoholistische dranken"
                },
                new Category
                {
                    CategoryType = "Voorgerecht"
                },
                new Category
                {
                    CategoryType = "Hoofdgerecht"
                },
                new Category
                {
                    CategoryType = "Nagerecht"
                }
            };

            if (context.Categories.Count() == 0)
            {
                context.Categories.AddRange(newCategories);
                context.SaveChanges();
            }

            var newProducts = new List<Product>
            {
                new Product{ ConsumableType = ConsumableType.Drink, Category = newCategories[0], Name = "Cola", Price = 1.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Drink, Category = newCategories[0], Name = "Fanta", Price = 1.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Drink, Category = newCategories[0], Name = "Ice Tea", Price = 1.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Drink, Category = newCategories[0], Name = "Spa blauw", Price = 1.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Drink, Category = newCategories[1], Name = "Koffie", Price = 1.30, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Drink, Category = newCategories[1], Name = "Thee", Price = 1.30, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Drink, Category = newCategories[2], Name = "Bier", Price = 2.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Drink, Category = newCategories[2], Name = "Rode wijn", Price = 2.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Drink, Category = newCategories[2], Name = "Witte wijn", Price = 2.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Drink, Category = newCategories[2], Name = "Whisky", Price = 2.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[3], Name = "Tomatensoep", Price = 4.00, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[3], Name = "Kippensoep", Price = 4.00, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[3], Name = "Groentesoep", Price = 4.00, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[3], Name = "Zalmsalade", Price = 4.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[3], Name = "Komokommersalade", Price = 4.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[3], Name = "Aardappelsalade", Price = 4.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[3], Name = "Macaronisalade", Price = 4.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[3], Name = "Fruitsalade", Price = 4.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[4], Name = "Visschotel", Price = 10.00, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[4], Name = "Pastaschotel", Price = 10.00, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[4], Name = "Lasagne", Price = 10.00, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[4], Name = "Gehaktschotel", Price = 10.00, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[4], Name = "Indische schotel", Price = 10.00, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[5], Name = "Ijkoffie", Price = 5.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[5], Name = "Dame blanche", Price = 5.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[5], Name = "Bananen split", Price = 5.50, VAT = VAT.Low, Availability = true},
                new Product{ ConsumableType = ConsumableType.Food, Category = newCategories[5], Name = "Chocolademousse", Price = 5.50, VAT = VAT.Low, Availability = true},
            };

            if (context.Products.Count() == 0)
            {
                context.Products.AddRange(newProducts);
                context.SaveChanges();
            }

            var newOrders = new List<Order>
            {
                new Order{ Products = new List<Product> { newProducts[0], newProducts[1], newProducts[2], newProducts[3], newProducts[4], newProducts[5], newProducts[6], newProducts[7] }, 
                Time = DateTime.ParseExact("18:00:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = true},
                new Order{ Products = new List<Product> { newProducts[11], newProducts[12], newProducts[13], newProducts[14], newProducts[15], newProducts[16], newProducts[17], newProducts[18] },
                Time = DateTime.ParseExact("18:05:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = true},
                new Order{ Products = new List<Product> { newProducts[8], newProducts[9], newProducts[10], newProducts[11], newProducts[12], newProducts[13], newProducts[14], newProducts[15] },
                Time = DateTime.ParseExact("18:10:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{ Products = new List<Product> { newProducts[0], newProducts[1], newProducts[2], newProducts[3], newProducts[4], newProducts[5], newProducts[6], newProducts[7] },
                Time = DateTime.ParseExact("18:15:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{ Products = new List<Product> { newProducts[8], newProducts[9], newProducts[10], newProducts[11], newProducts[12], newProducts[13], newProducts[14], newProducts[15] },
                Time = DateTime.ParseExact("18:20:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{ Products = new List<Product> { newProducts[11], newProducts[12], newProducts[13], newProducts[14], newProducts[15], newProducts[16], newProducts[17], newProducts[18] },
                Time = DateTime.ParseExact("18:25:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{ Products = new List<Product> { newProducts[0], newProducts[1], newProducts[2], newProducts[3], newProducts[4], newProducts[5], newProducts[6], newProducts[7] },
                Time = DateTime.ParseExact("18:30:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{ Products = new List<Product> { newProducts[8], newProducts[9], newProducts[10], newProducts[11], newProducts[12], newProducts[13], newProducts[14], newProducts[15] },
                Time = DateTime.ParseExact("18:35:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{ Products = new List<Product> { newProducts[11], newProducts[12], newProducts[13], newProducts[14], newProducts[15], newProducts[16], newProducts[17], newProducts[18] },
                Time = DateTime.ParseExact("18:40:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{ Products = new List<Product> { newProducts[0], newProducts[1], newProducts[2], newProducts[3], newProducts[4], newProducts[5], newProducts[6], newProducts[7] },
                Time = DateTime.ParseExact("18:45:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{ Products = new List<Product> { newProducts[8], newProducts[9], newProducts[10], newProducts[11], newProducts[12], newProducts[13], newProducts[14], newProducts[15] },
                Time = DateTime.ParseExact("18:50:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{Products = new List<Product> { newProducts[24], newProducts[25], newProducts[26], newProducts[17], newProducts[24], newProducts[25], newProducts[26], newProducts[25] },
                Time = DateTime.ParseExact("18:55:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
            };

            if (context.Orders.Count() == 0)
            {
                context.Orders.AddRange(newOrders);
                context.SaveChanges();
            }

            var newOrders2 = new List<Order>
            {
                new Order{ Products = new List<Product> { newProducts[1], newProducts[2], newProducts[3], newProducts[4], newProducts[5], newProducts[6], newProducts[7], newProducts[8] },
                Time = DateTime.ParseExact("19:15:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{ Products = new List<Product> { newProducts[12], newProducts[13], newProducts[14], newProducts[15] },
                Time = DateTime.ParseExact("19:25:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{ Products = new List<Product> { newProducts[24], newProducts[25], newProducts[26], newProducts[21] },
                Time = DateTime.ParseExact("19:55:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
            };

            if (context.Orders.Count() == 12)
            {
                context.Orders.AddRange(newOrders2);
                context.SaveChanges();
            }

            var newOrders3 = new List<Order>
            {
                new Order{ Products = new List<Product> { newProducts[2], newProducts[3], newProducts[4], newProducts[5], newProducts[6], newProducts[7], newProducts[8], newProducts[9] },
                Time = DateTime.ParseExact("18:15:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{ Products = new List<Product> { newProducts[18], newProducts[19], newProducts[20], newProducts[21] },
                Time = DateTime.ParseExact("18:25:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{ Products = new List<Product> { newProducts[24], newProducts[25], newProducts[26], newProducts[22] },
                Time = DateTime.ParseExact("18:55:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
            };

            if (context.Orders.Count() == 15)
            {
                context.Orders.AddRange(newOrders3);
                context.SaveChanges();
            }

            var newOrders4 = new List<Order>
            {
                new Order{ Products = new List<Product> { newProducts[2], newProducts[3], newProducts[4], newProducts[5], newProducts[6], newProducts[7], newProducts[8], newProducts[9] },
                Time = DateTime.ParseExact("19:50:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{ Products = new List<Product> { newProducts[18], newProducts[19], newProducts[20], newProducts[21] },
                Time = DateTime.ParseExact("19:55:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
                new Order{ Products = new List<Product> { newProducts[24], newProducts[25], newProducts[26], newProducts[17] },
                Time = DateTime.ParseExact("20:25:00", "HH:mm:ss", CultureInfo.InvariantCulture), Done = false},
            };

            if (context.Orders.Count() == 18)
            {
                context.Orders.AddRange(newOrders4);
                context.SaveChanges();
            }

            var Customers = new List<Customer>
            {
                new Customer
                {
                    LastName = "Standaard",
                    PhoneNumber = "1111111111",
                    EmailAdress = "Standaard@email.com"
                }
            };

            if (context.Customers.Count() == 0)
            {
                context.Customers.AddRange(Customers);
                context.SaveChanges();
            }

            var Reservations = new List<Reservation>
            {
                 new Reservation
                {
                    Customer = new Customer
                    {
                        LastName = "Baarsen",
                        PhoneNumber = "0618432278",
                        EmailAdress = "cust@email.com"
                    },
                    Tables = new List<Table> { newTables[0], newTables[1], newTables[2], newTables[3] },
                    Orders = new List<Order> { newOrders[0], newOrders[1], newOrders[2], newOrders[3], newOrders[4], newOrders[5], newOrders[6], newOrders[7], newOrders[8], newOrders[9], newOrders[10], newOrders[11]},
                    ReservationBool = true,
                    ReservationDate = DateTime.Parse("2019-10-01"),
                    StartTime = DateTime.ParseExact("18:00:00", "HH:mm:ss",
                    CultureInfo.InvariantCulture),
                    EndTime = DateTime.ParseExact("19:45:00", "HH:mm:ss", CultureInfo.InvariantCulture)
                },

                new Reservation
                {
                    Customer = new Customer
                    {
                        LastName = "Bosch",
                        PhoneNumber = "0695632278",
                        EmailAdress = "cust1@email.com"
                    },
                    Tables = new List<Table> { newTables[0] },
                    Orders = new List<Order> { newOrders[0], newOrders[1], newOrders[2] },
                    ReservationBool = false,
                    ReservationDate = DateTime.Parse("2019-12-10"),
                    StartTime = DateTime.ParseExact("19:15:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                    EndTime = DateTime.ParseExact("21:00:00", "HH:mm:ss", CultureInfo.InvariantCulture)
                },

                new Reservation
                {
                    Customer = new Customer
                    {
                        LastName = "Brock",
                        PhoneNumber = "0618439348",
                        EmailAdress = "cust2@email.com"
                    },
                    Tables = new List<Table> { newTables[0] },
                    Orders = new List<Order> { newOrders[0], newOrders[1], newOrders[2] },
                    ReservationBool = true,
                    ReservationDate = DateTime.Parse("2019-12-15"),
                    StartTime = DateTime.ParseExact("18:15:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                    EndTime = DateTime.ParseExact("20:00:00", "HH:mm:ss", CultureInfo.InvariantCulture)
                },

                new Reservation
                {
                    Customer = new Customer
                    {
                        LastName = "Roelofs",
                        PhoneNumber = "0653232278",
                        EmailAdress = "cust3@email.com"
                    },
                    Tables = new List<Table> { newTables[0] },
                    Orders = new List<Order> { newOrders[0], newOrders[1], newOrders[2] },
                    ReservationBool = false,
                    ReservationDate = DateTime.Parse("2020-01-10"),
                    StartTime = DateTime.ParseExact("18:05:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                    EndTime = DateTime.ParseExact("19:50:00", "HH:mm:ss", CultureInfo.InvariantCulture)
                }
        };

            if (context.Reservations.Count() == 0)
            {
                Reservations.ForEach(s => context.Reservations.Add(s));
                context.SaveChanges();
            }
        }
    }
}