using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    class Work
    {
        //data members for setting hour and minutes
        private int minutes;
        
        
        //calcuate hour and minutes from minutes in the file
        public int Minutes 
        {
            get => minutes % 60;
            set => minutes = value;
        }
        public int Hours
        {
            get => minutes / 60;
            set => minutes = value;
        }

        //data properties for saving the data from the file
        public string WorkType { get; set; }
        public double MaterialCost { get; set; }

        
        
        
    }
}
