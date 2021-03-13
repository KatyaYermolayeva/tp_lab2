using System;

namespace lab2
{
    public class ExtendedCustomer
    {
        public int id { get; set; }
        public string surname { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public bool gender { get; set; }
        public string nationality { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public DateTime birth_date { get; set; }
        public string phone_number { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public string district { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int house { get; set; }
        public int? flat { get; set; }
        public string credit_card_number { get; set; }
        public string bank_account_number { get; set; }
        public int shop_id { get; set; }
        public string email { get; set; }
        public override bool Equals(object obj)
        {
            return id == (obj as ExtendedCustomer).id &&
                surname == (obj as ExtendedCustomer).surname &&
                first_name == (obj as ExtendedCustomer).first_name &&
                second_name == (obj as ExtendedCustomer).second_name &&
                gender == (obj as ExtendedCustomer).gender &&
                phone_number == (obj as ExtendedCustomer).phone_number &&
                nationality == (obj as ExtendedCustomer).nationality &&
                height == (obj as ExtendedCustomer).height &&
                weight == (obj as ExtendedCustomer).weight &&
                birth_date == (obj as ExtendedCustomer).birth_date &&
                postcode == (obj as ExtendedCustomer).postcode &&
                country == (obj as ExtendedCustomer).country &&
                region == (obj as ExtendedCustomer).region &&
                district == (obj as ExtendedCustomer).district &&
                city == (obj as ExtendedCustomer).city &&
                street == (obj as ExtendedCustomer).street &&
                house == (obj as ExtendedCustomer).house &&
                flat == (obj as ExtendedCustomer).flat &&
                credit_card_number == (obj as ExtendedCustomer).credit_card_number &&
                bank_account_number == (obj as ExtendedCustomer).bank_account_number &&
                shop_id == (obj as ExtendedCustomer).shop_id &&
                email == (obj as ExtendedCustomer).email;
        }
    }
}
