using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BeketovVN.Sprint5.Task1.V7.Lib
{
    public class DataService : ISprint5Task1V7
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            double y;
            string stry;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((Math.Sin(x) / x + 1.2) - Math.Sin(x) * 2 - 2 * x), 2);
                stry = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, stry + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stry);
                }
            }
            return path;
        }
    }
}
