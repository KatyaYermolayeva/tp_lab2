using lab2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace lab2Tests
{
    public class BasicQueriesTests
    {
        BasicQueries basicQueries;
        public BasicQueriesTests()
        {
            var optionsBuilder = new DbContextOptionsBuilder<lab2.AppContext>();

            var options = optionsBuilder
                    .UseNpgsql("Host=localhost;Username=postgres;Password=password;Database=postgres;")
                    .Options;
            var context = new lab2.AppContext(options);
            context.Database.Migrate();
            basicQueries = new BasicQueries();
        }

        [Fact]
        public void GetSumWeightTest()
        {
            var result = basicQueries.GetSumWeight();
            Assert.Equal(334.32, result);
        }

        [Fact]
        public void GetCustomersFromBrestTest()
        {
            List<Customer> result = basicQueries.GetCustomersFromBrest();
            List<Customer> realCustomers = new List<Customer>();
            realCustomers.Add(new Customer
            {
                id = 2,
                surname = "Petrov",
                first_name = "Petr",
                second_name = "Petrovich",
                gender = true,
                nationality = "Belarusian",
                height = 1.67,
                weight = 65.3,
                birth_date = new System.DateTime(1987, 8, 1),
                phone_number = "375447851287",
                postcode = "220076",
                country = "Belarus",
                region = "Brestsky",
                district = "Brestsky",
                city = "Brest",
                street = "Pushkina",
                house = 15,
                flat = 2,
                credit_card_number = "zdr69365ysl15",
                bank_account_number = "12874981209"
            });
            realCustomers.Add(new Customer
            {
                id = 6,
                surname = "Petrova",
                first_name = "Maria",
                second_name = "Mihailovna",
                gender = false,
                nationality = "Belarusian",
                height = 1.65,
                weight = 59.0,
                birth_date = new System.DateTime(2000, 10, 17),
                phone_number = "375445679876",
                postcode = "220076",
                country = "Belarus",
                region = "Brestsky",
                district = "Brestsky",
                city = "Brest",
                street = "Volodarskogo",
                house = 17,
                flat = 64,
                credit_card_number = "byi32784lao63",
                bank_account_number = "27382991203"
            });
            realCustomers.Add(new Customer
            {
                id = 7,
                surname = "Smirnova",
                first_name = "Svetlana",
                second_name = "Stepanovna",
                gender = false,
                nationality = "Belarusian",
                height = 1.71,
                weight = 71.3,
                birth_date = new System.DateTime(1984, 4, 14),
                phone_number = "375291718190",
                postcode = "220076",
                country = "Belarus",
                region = "Brestsky",
                district = "Brestsky",
                city = "Brest",
                street = "Morozova",
                house = 22,
                flat = 87,
                credit_card_number = "off11874oqi81",
                bank_account_number = "34729502493"
            });
            Assert.Equal(realCustomers, result);
        }

        [Fact]
        public void GetAllCustomersTest()
        {
            List<ShortCustomer> realCustomers = new List<ShortCustomer>();
            var result = basicQueries.GetAllCustomers();

            realCustomers.Add(new ShortCustomer
            {
                Id = 3,
                Surname = "Ivanova",
                FirstName = "Anna",
                PhoneNumber = "375298365509",
                CreditCardNumber = "top63398orp16",
                ShopName = "SHOP1"
            });
            realCustomers.Add(new ShortCustomer
            {
                Id = 7,
                Surname = "Smirnova",
                FirstName = "Svetlana",
                PhoneNumber = "375291718190",
                CreditCardNumber = "off11874oqi81",
                ShopName = "SHOP2"
            });
            realCustomers.Add(new ShortCustomer
            {
                Id = 2,
                Surname = "Petrov",
                FirstName = "Petr",
                PhoneNumber = "375447851287",
                CreditCardNumber = "zdr69365ysl15",
                ShopName = "SHOP2"
            });

            realCustomers.Add(new ShortCustomer
            {
                Id = 1,
                Surname = "Ivanov",
                FirstName = "Ivan",
                PhoneNumber = "375291234567",
                CreditCardNumber = "byt23473hfw73",
                ShopName = "SHOP3"
            });
            realCustomers.Add(new ShortCustomer
            {
                Id = 6,
                Surname = "Petrova",
                FirstName = "Maria",
                PhoneNumber = "375445679876",
                CreditCardNumber = "byi32784lao63",
                ShopName = "SHOP4"
            });
            realCustomers.Add(new ShortCustomer
            {
                Id = 5,
                Surname = "Kotov",
                FirstName = "Vladimir",
                PhoneNumber = "375292340987",
                CreditCardNumber = "wer46709odk92",
                ShopName = "SHOP5"
            });

            realCustomers.Add(new ShortCustomer
            {
                Id = 4,
                Surname = "Smirnov",
                FirstName = "Miron",
                PhoneNumber = "375338175098",
                CreditCardNumber = "iiu89017zzk22",
                ShopName = "SHOP5"
            });

            Assert.Equal(realCustomers, result);

        }

        [Fact]
        public void AddColumnsTest()
        {
            var result = basicQueries.AddColumns();
            Assert.Equal(7, result);
        }

        [Fact]
        public void AddShopTableTest()
        {
            var result = basicQueries.AddShopTable();
            Assert.Equal(7, result);
        }

        [Fact]
        public void CountCustomersByHeightTest()
        {
            var result = basicQueries.CountCustomersByHeight();
            Assert.Equal(2, result);
        }

        [Fact]
        public void GetMinMaxWeightsTest()
        {
            var result = basicQueries.GetMinMaxWeights();
            var realWeights = new Tuple<double, double>(59.0, 100.3);
            Assert.Equal(realWeights, result);
        }

        [Fact]
        public void GetCustomersAndShopsByIDTest()
        {
            List<Tuple<ExtendedCustomer, Shop>> realCustomersAndShops = new List<Tuple<ExtendedCustomer, Shop>>();
            var result = basicQueries.GetCustomersAndShopsByID();

            realCustomersAndShops.Add(new Tuple<ExtendedCustomer, Shop>(new ExtendedCustomer()
            {
                id = 7,
                surname = "Smirnova",
                first_name = "Svetlana",
                second_name = "Stepanovna",
                gender = false,
                nationality = "Belarusian",
                height = 1.71,
                weight = 71.3,
                birth_date = new System.DateTime(1984, 4, 14),
                phone_number = "375291718190",
                postcode = "220076",
                country = "Belarus",
                region = "Brestsky",
                district = "Brestsky",
                city = "Brest",
                street = "Morozova",
                house = 22,
                flat = 87,
                credit_card_number = "off11874oqi81",
                bank_account_number = "34729502493",
                shop_id = 2,
                email = "Smirnova@gmail.com"
            }, new Shop()
            {
                id = 2,
                shop_name = "SHOP2",
                shop_description = "NOT SO GOOD SHOP"
            }));

            realCustomersAndShops.Add(new Tuple<ExtendedCustomer, Shop>(new ExtendedCustomer()
            {
                id = 2,
                surname = "Petrov",
                first_name = "Petr",
                second_name = "Petrovich",
                gender = true,
                nationality = "Belarusian",
                height = 1.67,
                weight = 65.3,
                birth_date = new System.DateTime(1987, 8, 1),
                phone_number = "375447851287",
                postcode = "220076",
                country = "Belarus",
                region = "Brestsky",
                district = "Brestsky",
                city = "Brest",
                street = "Pushkina",
                house = 15,
                flat = 2,
                credit_card_number = "zdr69365ysl15",
                bank_account_number = "12874981209",
                shop_id = 2,
                email = "Petrov@gmail.com"
            }, new Shop()
            {
                id = 2,
                shop_name = "SHOP2",
                shop_description = "NOT SO GOOD SHOP"
            }));

            realCustomersAndShops.Add(new Tuple<ExtendedCustomer, Shop>(new ExtendedCustomer()
            {
                id = 6,
                surname = "Petrova",
                first_name = "Maria",
                second_name = "Mihailovna",
                gender = false,
                nationality = "Belarusian",
                height = 1.65,
                weight = 59.0,
                birth_date = new System.DateTime(2000, 10, 17),
                phone_number = "375445679876",
                postcode = "220076",
                country = "Belarus",
                region = "Brestsky",
                district = "Brestsky",
                city = "Brest",
                street = "Volodarskogo",
                house = 17,
                flat = 64,
                credit_card_number = "byi32784lao63",
                bank_account_number = "27382991203",
                shop_id = 4,
                email = "Petrova@gmail.com"
            }, new Shop()
            {
                id = 4,
                shop_name = "SHOP4",
                shop_description = "VERY GOOD SHOP"
            }));


            Assert.Equal(realCustomersAndShops, result);
        }
    }
}
