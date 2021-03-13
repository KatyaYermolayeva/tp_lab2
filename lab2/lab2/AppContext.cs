using Microsoft.EntityFrameworkCore;

namespace lab2
{
    public class AppContext : DbContext
    {
        public AppContext() { }

        public DbSet<Customer> customer { get; set; }

        public DbSet<ExtendedCustomer> extended_customer { get; set; }
        public DbSet<Shop> shop { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=password");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    id = 1,
                    surname = "Ivanov",
                    first_name = "Ivan",
                    second_name = "Ivanovich",
                    gender = true,
                    nationality = "Belarusian",
                    height = 1.8,
                    weight = 79.5,
                    birth_date = new System.DateTime(1990, 4, 21),
                    phone_number = "375291234567",
                    postcode = "220076",
                    country = "Belarus",
                    region = "Minsky",
                    district = "Minsky",
                    city = "Minsk",
                    street = "Slobodskaya",
                    house = 23,
                    flat = 117,
                    credit_card_number = "byt23473hfw73",
                    bank_account_number = "32784872371"
                },
                new Customer
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
                },
                new Customer
                {
                    id = 3,
                    surname = "Ivanova",
                    first_name = "Anna",
                    second_name = "Ivanovna",
                    gender = false,
                    nationality = "Belarusian",
                    height = 1.65,
                    weight = 89.1,
                    birth_date = new System.DateTime(2003, 12, 6),
                    phone_number = "375298365509",
                    postcode = "220076",
                    country = "Belarus",
                    region = "Minsky",
                    district = "Minsky",
                    city = "Minsk",
                    street = "Pobedy square",
                    house = 7,
                    flat = 213,
                    credit_card_number = "top63398orp16",
                    bank_account_number = "41409212945"
                },
                new Customer
                {
                    id = 4,
                    surname = "Smirnov",
                    first_name = "Miron",
                    second_name = "Semenovich",
                    gender = true,
                    nationality = "Belarusian",
                    height = 1.8,
                    weight = 89.22,
                    birth_date = new System.DateTime(1997, 1, 13),
                    phone_number = "375338175098",
                    postcode = "220076",
                    country = "Belarus",
                    region = "Gomelsky",
                    district = "Gomelsky",
                    city = "Gomel",
                    street = "Dzerzhinskogo",
                    house = 4,
                    flat = 23,
                    credit_card_number = "iiu89017zzk22",
                    bank_account_number = "22973076899"
                },
                 new Customer
                 {
                     id = 5,
                     surname = "Kotov",
                     first_name = "Vladimir",
                     second_name = "Igorevich",
                     gender = true,
                     nationality = "Belarusian",
                     height = 1.89,
                     weight = 100.3,
                     birth_date = new System.DateTime(1995, 5, 8),
                     phone_number = "375292340987",
                     postcode = "220076",
                     country = "Belarus",
                     region = "Minsky",
                     district = "Soligorsky",
                     city = "Soligorsk",
                     street = "Lenina",
                     house = 81,
                     flat = 55,
                     credit_card_number = "wer46709odk92",
                     bank_account_number = "16329993456"
                 },
                new Customer
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
                },
                new Customer
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
                }
                );
        }

        public AppContext(DbContextOptions<AppContext> options) : base(options) { }
    }
}
