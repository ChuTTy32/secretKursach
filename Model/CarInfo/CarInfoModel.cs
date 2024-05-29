using Model.Order;
namespace Model.CarInfo
{
    public class CarInfoModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
        public int Power { get; set; }
        public string Type { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public float Value { get; set; }
        public string Serial { get; set; }
        public IEnumerable<OrderModel> Orders { get; set; }
    }
}
