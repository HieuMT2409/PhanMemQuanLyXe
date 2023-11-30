using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThueXeOTo.Database
{
    public class Report
    {
        public int Id { get; set; }
        public string NameCar { get; set; }
        public string Company { get; set; }
        public string Type { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public string Price { get; set; }


    }
}
