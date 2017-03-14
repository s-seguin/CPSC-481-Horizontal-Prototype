namespace CPSC_481_Horizontal_Prototype.Classes
{
    public class MenuItem
    {
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set;}

        public MenuItem(string name, string description, double price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}