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
            string outputFilePath = @"C:\DataSprint5\OutPutDataFileTask7V7.txt";

            
                // Проверяем существование исходного файла
                if (File.Exists(path))
                {
                    // Создаем новый файл для записи результата
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        // Читаем все строки из исходного файла
                        using (StreamReader reader = new StreamReader(path))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string lineWithoutEnglishWords = RemoveEnglishWords(line);
                                // Записываем результат в новый файл
                                writer.WriteLine(lineWithoutEnglishWords);
                            }
                        }
                    }

                    return outputFilePath;
                }
                else
                {
                    return "Исходный файл не найден.";
                }
            
        }

        // Метод для удаления английских слов из строки
        private string RemoveEnglishWords(string input)
        {
            // Используем регулярное выражение для поиска английских слов
            string pattern = @"\b[A-Za-z]+\b";
            string result = Regex.Replace(input, pattern, string.Empty);
            return result;
        }
    }
}