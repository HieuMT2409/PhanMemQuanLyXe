using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThueXeOTo.Database
{
    public class Order
    {
        public int ID {  get; set; }
        public string NameUser { get; set; }
        public string SDT { get; set; }
        public string Address { get; set; }
        public string NameCar { get; set; }
        public string Feature { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public string TypePay { get; set; }
    }
}
