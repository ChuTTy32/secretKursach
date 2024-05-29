using Model.Order;
using Model.Position;


namespace Model.Staff
{
    public class StaffModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Experience { get; set; }
        public bool IsAdmin { get; set; }
        public int PositionId { get; set; }
        public string Schedule { get; set; }
        public PositionModel Position { get; set; }
        public IEnumerable<OrderModel> Orders { get; set; }
    }
}
