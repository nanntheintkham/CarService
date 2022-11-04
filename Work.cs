using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    class Work
    {
        public static int Hour { get; set; }
        public double TimeReq { get; set; }
        public string WorkType { get; set; }
        public double MaterialCost { get; set; }
        public double TimeCost { get; set; }

        public double TotalCost { get; set; }

        public double MaterialTotal { get; set; }
        public double TimeTotal { get; set; }

        public double Count { get; set; }
        
    }
}
