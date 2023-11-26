using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BeketovVN.Sprint5.Task4.V24.Lib
{
    public class DataService : ISprint5Task4V24
    {
        public double LoadFromDataFile(string path)
        {
            string strY = File.ReadAllText(path);
            double x = Convert.ToDouble(strY);
            double res = Math.Round((Math.Pow(x, -2) + 2) * Math.Sin(x), 3);
            return res;
        }
    }
}
