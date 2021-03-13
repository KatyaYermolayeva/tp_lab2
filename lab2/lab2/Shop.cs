namespace lab2
{
    public class Shop
    {
        public int id { get; set; }
        public string shop_name { get; set; }
        public string shop_description { get; set; }

        public override bool Equals(object obj)
        {

            return id == (obj as Shop).id &&
                shop_description == (obj as Shop).shop_description &&
                shop_name == (obj as Shop).shop_name;
        }
    }
}
