using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Experience { get; set; }
        public bool IsAdmin { get; set; }
        public int PositionId { get; set; }
        public string Schedule {  get; set; }
        public Position Position { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
