using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBox_HW_Theme_6.Service
{
    internal class FileProcessing
    {
        private static string _path;
        
        public static void SetPath(string path) { _path = path; }
        public string ReadFileData()
        {
            string dataText = String.Empty;
            try
            {
                using (FileStream fs = File.OpenRead(@_path))
                {
                    byte[] dataBytes = new byte[fs.Length]; //Создание массива типа байт для считывания данных
                    fs.Read(dataBytes, 0, dataBytes.Length); //Счит-е данных из файла в виде байт
                    dataText = System.Text.Encoding.Default.GetString(dataBytes);//Декодинг байт в строку
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataText;
        }

        public void WriteFileData(string dataText)
        {
            try
            {
                using(FileStream fs = new FileStream(@_path, FileMode.OpenOrCreate))
                {
                    byte[] dataBytes = System.Text.Encoding.Default.GetBytes(dataText);//Преобразование строки в байты
                    fs.Write(dataBytes, 0, dataBytes.Length);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
