using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBox_HW_Theme_6.Service
{
    internal class FileProcessing
    {
        public string ReadFileData(string path)
        {
            string dataText = String.Empty;
            try
            {
                using (FileStream fs = File.OpenRead(@path))
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

        //public bool WriteFileData(string path)
        //{
        //    try
        //    {

        //    }
        //    catch(Exception exception)
        //    {
        //        Console.WriteLine(exception.Message);
        //    }
        //}
    }
}
