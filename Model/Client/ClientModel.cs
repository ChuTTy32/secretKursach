using Model.Order;

namespace Model.Client
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public IEnumerable<OrderModel> Orders { get; set; }
    }
}
