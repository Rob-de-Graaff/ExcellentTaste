using ExcellentTaste.Models;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExcellentTaste.DAL
{
    public class ExcellentInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ExcellentContext>
    {
        //public string emailinput { get; set; }
        //int itemid = 0;
        protected override void Seed(ExcellentContext context)
        {
            var Employees = new List<Employee>
            {
                new Employee{EmailAdress="Admin@email.com", Password = "@1234A", FirstName = "Jan", LastName = "Janssen", Role = Role.Administrator},
                new Employee{EmailAdress="Ober@email.com", Password = "@2345B", FirstName = "Bert", LastName = "Bartens", Role = Role.Ober},
                new Employee{EmailAdress="Kok@email.com", Password = "@3456C", FirstName = "Truus", LastName = "Tenten", Role = Role.Kok},
                new Employee{EmailAdress="Barman@email.com", Password = "@4567D", FirstName = "Trien", LastName = "Trientjes", Role = Role.Barman}
            };

            var Reservations = new List<Reservation>
            {
                //new Reservation{LastName="Klaasen", ReservationBool=true, ReservationDate=DateTime.Parse("2019-12-01"), StartTime=DateTime.ParseExact("18:00:00", "HH:mm;ss", CultureInfo.InvariantCulture), EndTime=DateTime.ParseExact("19:45:00", "HH:mm;ss", CultureInfo.InvariantCulture)},
                //new Reservation{LastName="Jansen", ReservationBool=false, ReservationDate=DateTime.Parse("2019-12-10"), StartTime=DateTime.ParseExact("19:15:00", "HH:mm;ss", CultureInfo.InvariantCulture), EndTime=DateTime.ParseExact("21:00:00", "HH:mm;ss", CultureInfo.InvariantCulture)},
                new Reservation{LastName="Haalstra", ReservationBool=true, ReservationDate=DateTime.Parse("2019-12-15"), StartTime=DateTime.ParseExact("18:15:00", "HH:mm;ss", CultureInfo.InvariantCulture), EndTime=DateTime.ParseExact("20:00:00", "HH:mm;ss", CultureInfo.InvariantCulture)},
                new Reservation{LastName="Boers", ReservationBool=false, ReservationDate=DateTime.Parse("2020-01-10"), StartTime=DateTime.ParseExact("18:05:00", "HH:mm;ss", CultureInfo.InvariantCulture), EndTime=DateTime.ParseExact("19:50:00", "HH:mm;ss", CultureInfo.InvariantCulture)},
            };

            var Customers = new List<Customer>
            {
                //new Customer{LastName="Baarsen", PhoneNumber="0618432278", EmailAdress="cust@email.com"},
                //new Customer{LastName="Bosch", PhoneNumber="0695632278", EmailAdress="cust1@email.com"},
                new Customer{LastName="Brock", PhoneNumber="0618439348", EmailAdress="cust2@email.com"},
                new Customer{LastName="Roelofs", PhoneNumber="0653232278", EmailAdress="cust3@email.com"},
            };

            //List<int> Allprimarykeys = new List<int>();

            //foreach (var item in Customers)
            //{

            //    if (item.EmailAdress == emailinput)
            //    {
            //        Allprimarykeys.Add(item.CustomerID);
            //    }
            //}

            new Reservation
            {
                Customer = new Customer
                {
                    LastName = "Baarsen",
                    PhoneNumber = "0618432278",
                    EmailAdress = "cust@email.com"
                },
                ReservationBool = true,
                ReservationDate = DateTime.Parse("2019-12-01"),
                StartTime = DateTime.ParseExact("18:00:00", "HH:mm;ss",
                CultureInfo.InvariantCulture),
                EndTime = DateTime.ParseExact("19:45:00", "HH:mm;ss", CultureInfo.InvariantCulture)
            };

            new Reservation 
            {
                Customer = new Customer
                {
                    LastName="Bosch", 
                    PhoneNumber="0695632278", 
                    EmailAdress="cust1@email.com"
                },
                ReservationBool = false, 
                ReservationDate = DateTime.Parse("2019-12-10"), 
                StartTime = DateTime.ParseExact("19:15:00", "HH:mm;ss", CultureInfo.InvariantCulture), 
                EndTime = DateTime.ParseExact("21:00:00", "HH:mm;ss", CultureInfo.InvariantCulture) };

            //int i = 0;
            //foreach (var item in Reservations)
            //{
            //    item.Customer = Customers[i];
            //    i++;
            //}
        }
    }
}