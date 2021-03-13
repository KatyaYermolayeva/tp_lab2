namespace lab2
{
    public class ShortCustomer
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string CreditCardNumber { get; set; }
        public string ShopName { get; set; }
        public override bool Equals(object obj)
        {

            return Id == (obj as ShortCustomer).Id &&
                Surname == (obj as ShortCustomer).Surname &&
                FirstName == (obj as ShortCustomer).FirstName &&
                PhoneNumber == (obj as ShortCustomer).PhoneNumber &&
                CreditCardNumber == (obj as ShortCustomer).CreditCardNumber &&
                ShopName == (obj as ShortCustomer).ShopName;
        }
    }
}
