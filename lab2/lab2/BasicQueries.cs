using Npgsql;
using System;
using System.Collections.Generic;

namespace lab2
{
    public class BasicQueries
    {
        string connectionString = "Server=127.0.0.1;User Id=postgres;Password=password;Database=postgres";
        NpgsqlConnection connection;

        public BasicQueries(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
        }
        public BasicQueries()
        {
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
        }

        ~BasicQueries()
        {
            connection.Close();
        }

        public List<Customer> GetCustomersFromBrest()
        {
            var sql = "SELECT * FROM customer WHERE city = 'Brest'";
            using var cmd = new NpgsqlCommand(sql, connection);
            var reader = cmd.ExecuteReader();
            List<Customer> customers = new List<Customer>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    customers.Add(new Customer()
                    {
                        id = reader.GetInt32(0),
                        surname = reader.GetString(1),
                        first_name = reader.GetString(2),
                        second_name = reader.GetString(3),
                        gender = reader.GetBoolean(4),
                        nationality = reader.GetString(5),
                        height = reader.GetDouble(6),
                        weight = reader.GetDouble(7),
                        birth_date = reader.GetDateTime(8),
                        phone_number = reader.GetString(9),
                        postcode = reader.GetString(10),
                        country = reader.GetString(11),
                        region = reader.GetString(12),
                        district = reader.GetString(13),
                        city = reader.GetString(14),
                        street = reader.GetString(15),
                        house = reader.GetInt32(16),
                        flat = reader.GetInt32(17),
                        credit_card_number = reader.GetString(18),
                        bank_account_number = reader.GetString(19)
                    });
                }
            }

            reader.Close();
            return customers;
        }
        public List<ShortCustomer> GetAllCustomers()
        {
            var sql = "SELECT customer.id, surname, first_name, phone_number, credit_card_number, shop_name " +
                "FROM customer JOIN shop ON customer.shop_id = shop.id";
            using var cmd = new NpgsqlCommand(sql, connection);
            var reader = cmd.ExecuteReader();
            List<ShortCustomer> customers = new List<ShortCustomer>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    customers.Add(new ShortCustomer()
                    {
                        Id = reader.GetInt32(0),
                        Surname = reader.GetString(1),
                        FirstName = reader.GetString(2),
                        PhoneNumber = reader.GetString(3),
                        CreditCardNumber = reader.GetString(4),
                        ShopName = reader.GetString(5)
                    });
                }
            }

            reader.Close();
            return customers;
        }
        public int AddColumns()
        {
            var sql = "ALTER TABLE customer " +
                "ADD COLUMN shop_id INT, ADD COLUMN email VARCHAR(30)";
            using var cmd = new NpgsqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            sql = "UPDATE customer SET shop_id = house % 7 + 1, email = surname || '@gmail.com'";
            using var cmd2 = new NpgsqlCommand(sql, connection);
            int result = cmd2.ExecuteNonQuery();
            return result;
        }
        public int AddShopTable()
        {
            var sql = "CREATE TABLE shop (id SERIAL PRIMARY KEY," +
                " shop_name VARCHAR(30), " +
                "shop_description VARCHAR(225))";
            using var cmd = new NpgsqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            sql = "INSERT INTO shop (shop_name, shop_description) VALUES('SHOP1', 'GOOD SHOP')," +
                " ('SHOP2', 'NOT SO GOOD SHOP'), ('SHOP3', 'VERY BAD SHOP'), " +
                "('SHOP4', 'VERY GOOD SHOP'), ('SHOP5', 'BAD SHOP')," +
                " ('SHOP6', 'NOT SO BAD SHOP'), ('SHOP7', 'AWESOME SHOP')";
            using var cmd2 = new NpgsqlCommand(sql, connection);
            return cmd2.ExecuteNonQuery();
        }
        public long CountCustomersByHeight()
        {
            var sql = "SELECT count(*) FROM customer WHERE height = 1.65";
            using var cmd = new NpgsqlCommand(sql, connection);
            return (long)cmd.ExecuteScalar();
        }
        public double GetSumWeight()
        {
            var sql = "SELECT sum(weight) FROM customer WHERE gender = true";
            using var cmd = new NpgsqlCommand(sql, connection);
            return (double)cmd.ExecuteScalar();
        }
        public Tuple<double, double> GetMinMaxWeights()
        {
            var sql = "SELECT min(weight), max(weight) FROM customer";
            using var cmd = new NpgsqlCommand(sql, connection);
            var reader = cmd.ExecuteReader();
            reader.Read();
            var result = new Tuple<double, double>(reader.GetDouble(0), reader.GetDouble(1));
            reader.Close();
            return result;
        }
        public List<Tuple<ExtendedCustomer, Shop>> GetCustomersAndShopsByID()
        {
            var sql = "SELECT * FROM customer INNER JOIN shop ON customer.shop_id = shop.id WHERE shop.id IN(2, 4)";
            using var cmd = new NpgsqlCommand(sql, connection);
            var reader = cmd.ExecuteReader();
            List<Tuple<ExtendedCustomer, Shop>> customersAndShops = new List<Tuple<ExtendedCustomer, Shop>>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    customersAndShops.Add(new Tuple<ExtendedCustomer, Shop>(new ExtendedCustomer()
                    {
                        id = reader.GetInt32(0),
                        surname = reader.GetString(1),
                        first_name = reader.GetString(2),
                        second_name = reader.GetString(3),
                        gender = reader.GetBoolean(4),
                        nationality = reader.GetString(5),
                        height = reader.GetDouble(6),
                        weight = reader.GetDouble(7),
                        birth_date = reader.GetDateTime(8),
                        phone_number = reader.GetString(9),
                        postcode = reader.GetString(10),
                        country = reader.GetString(11),
                        region = reader.GetString(12),
                        district = reader.GetString(13),
                        city = reader.GetString(14),
                        street = reader.GetString(15),
                        house = reader.GetInt32(16),
                        flat = reader.GetInt32(17),
                        credit_card_number = reader.GetString(18),
                        bank_account_number = reader.GetString(19),
                        shop_id = reader.GetInt32(20),
                        email = reader.GetString(21)
                    }, new Shop()
                    {
                        id = reader.GetInt32(22),
                        shop_name = reader.GetString(23),
                        shop_description = reader.GetString(24)
                    }));
                }
            }

            reader.Close();
            return customersAndShops;
        }
    }
}
