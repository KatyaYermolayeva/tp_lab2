using System;

namespace lab2
{
    public class Customer
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

        public override bool Equals(object obj)
        {

            return id == (obj as Customer).id &&
                surname == (obj as Customer).surname &&
                first_name == (obj as Customer).first_name &&
                second_name == (obj as Customer).second_name &&
                gender == (obj as Customer).gender &&
                phone_number == (obj as Customer).phone_number &&
                nationality == (obj as Customer).nationality &&
                height == (obj as Customer).height &&
                weight == (obj as Customer).weight &&
                birth_date == (obj as Customer).birth_date &&
                postcode == (obj as Customer).postcode &&
                country == (obj as Customer).country &&
                region == (obj as Customer).region &&
                district == (obj as Customer).district &&
                city == (obj as Customer).city &&
                street == (obj as Customer).street &&
                house == (obj as Customer).house &&
                flat == (obj as Customer).flat &&
                credit_card_number == (obj as Customer).credit_card_number &&
                bank_account_number == (obj as Customer).bank_account_number;
        }
    }
}
