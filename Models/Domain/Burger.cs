namespace BurgerApp.Models.Domain
{
    public class Burger
    {
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public bool IsVegeterian { get; set; }

        public bool IsVegan { get; set; }

        public bool HasFries { get; set; }

        public Burger(string name,decimal price,bool isVegetrian,bool isVegan,bool hasFries)
        {
            if(name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Price = price;
            IsVegeterian = isVegetrian;
            IsVegan = isVegan;
            HasFries = hasFries;
        }

    }
}
