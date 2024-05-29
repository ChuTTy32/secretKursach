using Model.CarInfo;
using Model.Client;
using Model.Staff;

namespace Model.Order
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string Description { get; set; }
        public int ClientId { get; set; }
        public int CarId { get; set; }
        public int WorkerId { get; set; }
        public decimal Price { get; set; }
        public StaffModel Worker { get; set; }
        public ClientModel Client { get; set; }
        public CarInfoModel Car { get; set; }
    }
}
