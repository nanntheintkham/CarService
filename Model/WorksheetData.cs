using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Model
{
    internal class WorksheetData
    {
        public double TotalCost { get; set; }
        public double MaterialTotal { get; set; }
        public double TimeTotal { get; set; }
        public int WorksheetCount { get; set; }
        public int Count { get; set; } = 0;
        public int InvoicedHours { get; set; }
        public int InvoicedMinutes { get; set; }

    }
}
