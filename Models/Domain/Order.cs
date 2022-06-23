namespace BurgerApp.Models.Domain
{
    public class Order
    {
        public string FullName { get; set; }

        public string Address { get; set; }

        public bool IsDelivered { get; private set; }

        public string Location { get; set; }

        public IEnumerable<Burger> Burgers { get; set; } = new List<Burger>();

        public Order (string fullname,string adress,bool isDelivered,string location,IEnumerable<Burger> burgers)
        {
            FullName = fullname;
            Address = adress;
            IsDelivered = false;
            Location = location;
            Burgers = burgers;
        }

        public void Deliver()
        {
            if (IsDelivered)
            {
                throw new Exception(" Can not be delivered");
            }

            IsDelivered = true;
        }

        
    }
}

