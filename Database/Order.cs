using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThueXeOTo.Database
{
    public class Order
    {
        public string ID {  get; set; }
        public string NameUser { get; set; }
        public string SDT { get; set; }
        public string NameCar { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public string TypePay { get; set; }
    }
}
