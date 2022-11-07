using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    internal class WorkParser : IFileParser
    {
        //Parse the txt file and read into the list
        public List<T> ParseFiles<T>(string filePath)
        {
            List<Work> workData = new List<Work>();

            String fileToLoad = String.Format(filePath);
            using (StreamReader r = new StreamReader(fileToLoad))
            {
                string line;
                while((line = r.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');

                    Work wdb = new Work
                    {
                        WorkType = parts[0],
                        Minutes = Convert.ToInt16(parts[1]),
                        MaterialCost = Convert.ToDouble(parts[2])
                    };
                    workData.Add(wdb);
                }
            }

            return new List<T>(workData as IEnumerable<T> ?? throw new InvalidOperationException());
        }

        


    }
}
