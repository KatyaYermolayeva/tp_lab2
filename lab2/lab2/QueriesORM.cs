using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab2
{
    public class QueriesORM
    {
        string connectionString = "Server=127.0.0.1;User Id=postgres;Password=password;Database=postgres";
        AppContext appContext;

        public QueriesORM(string connectionString)
        {
            this.connectionString = connectionString;
            var optionsBuilder = new DbContextOptionsBuilder<AppContext>();

            var options = optionsBuilder
                    .UseNpgsql(connectionString)
                    .Options;
            appContext = new AppContext(options);
        }
        public QueriesORM()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppContext>();

            var options = optionsBuilder
                    .UseNpgsql(connectionString)
                    .Options;
            appContext = new AppContext(options);
        }

        public List<Customer> GetCustomersFromBrest()
        {
            return appContext.customer.Where(c => c.city == "Brest").ToList();
        }
        public List<ShortCustomer> GetAllCustomers()
        {
            var customers = from c in appContext.Set<ExtendedCustomer>()
                            join s in appContext.Set<Shop>()
                                on c.shop_id equals s.id
                            select new ShortCustomer()
                            {
                                Id = c.id,
                                Surname = c.surname,
                                CreditCardNumber = c.credit_card_number,
                                FirstName = c.first_name,
                                PhoneNumber = c.phone_number,
                                ShopName = s.shop_name
                            };
            return customers.ToList();
        }
        public int AddColumns()
        {
            var sql = "ALTER TABLE customer " +
                "ADD COLUMN shop_id INT, ADD COLUMN email VARCHAR(30)";
            appContext.Database.ExecuteSqlRaw(sql);
            sql = "ALTER TABLE customer " +
                "RENAME TO extended_customer";
            appContext.Database.ExecuteSqlRaw(sql);
            sql = "UPDATE extended_customer SET shop_id = house % 7 + 1, email = surname || '@gmail.com'";
            return appContext.Database.ExecuteSqlRaw(sql);
        }
        public int AddShopTable()
        {
            var sql = "CREATE TABLE shop (id SERIAL PRIMARY KEY," +
                " shop_name VARCHAR(30), " +
                "shop_description VARCHAR(225))";
            appContext.Database.ExecuteSqlRaw(sql);
            sql = "INSERT INTO shop (shop_name, shop_description) VALUES('SHOP1', 'GOOD SHOP')," +
                " ('SHOP2', 'NOT SO GOOD SHOP'), ('SHOP3', 'VERY BAD SHOP'), " +
                "('SHOP4', 'VERY GOOD SHOP'), ('SHOP5', 'BAD SHOP')," +
                " ('SHOP6', 'NOT SO BAD SHOP'), ('SHOP7', 'AWESOME SHOP')";
           return appContext.Database.ExecuteSqlRaw(sql);
        }
        public long CountCustomersByHeight()
        {
            return appContext.customer
                .Count(c => c.height == 1.65);
        }
        public double GetSumWeight()
        {
            return appContext.customer
                .Where(c => c.gender == true).Sum(c => c.weight);
        }
        public Tuple<double, double> GetMinMaxWeights()
        {
            double max = appContext.customer.Max(c => c.weight);
            double min = appContext.customer.Min(c => c.weight);
            var result = new Tuple<double, double>(min, max);
            return result;
        }
        public List<Tuple<ExtendedCustomer, Shop>> GetCustomersAndShopsByID()
        {
            var customersAndShops = from c in appContext.Set<ExtendedCustomer>()
                                    join s in appContext.Set<Shop>()
                                        on c.shop_id equals s.id
                                    where s.id == 2 || s.id == 4
                                    select new Tuple<ExtendedCustomer, Shop>(c, s);
            return customersAndShops.ToList();
        }
    }
}
