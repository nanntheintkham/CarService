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
                        TimeReq = Convert.ToDouble(parts[1]),
                        MaterialCost = Convert.ToDouble(parts[2])
                    };
                    workData.Add(wdb);
                }
            }

            return new List<T>(workData as IEnumerable<T> ?? throw new InvalidOperationException());
        }

        


    }
}
