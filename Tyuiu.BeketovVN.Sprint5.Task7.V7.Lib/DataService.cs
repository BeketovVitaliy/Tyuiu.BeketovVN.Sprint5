using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BeketovVN.Sprint5.Task7.V7.Lib
{
    public class DataService : ISprint5Task7V7
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V7.txt";
            FileInfo fileinfo = new FileInfo(pathSaveFile);
            bool fileexists = fileinfo.Exists;

            if (fileexists)
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];
                        if (((c >= 'А') && (c <= 'Я')) == false)
                        {
                            strLine = strLine + line[i];
                        }

                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }

                return pathSaveFile;
            }
        }
    }
}
