using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int Id {  get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string Description { get; set; }
        public int ClientId { get; set; }
        public int CarId { get; set; }
        public int WorkerId { get; set; }
        public decimal Price { get; set; }
        public Staff Worker { get; set; }
        public Client Client { get; set; }
        public CarInfo Car { get; set; }
    }
}
