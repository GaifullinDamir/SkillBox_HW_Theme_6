using System;
using System.IO;
using System.IO.Compression;


namespace SkillBox_HW_Theme_6.Infrastructure
{
    internal class FileProcessing
    {
        private static string _path = String.Empty;

        public static void SetPath(string path) { _path = path; }
        public string ReadFileData()
        {
            string dataText = string.Empty;
            try
            {
                using (FileStream fs = File.OpenRead(@_path))
                {
                    byte[] dataBytes = new byte[fs.Length]; //Создание массива типа байт для считывания данных
                    fs.Read(dataBytes, 0, dataBytes.Length); //Счит-е данных из файла в виде байт
                    dataText = System.Text.Encoding.Default.GetString(dataBytes);//Декодинг байт в строку
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return dataText;
        }

        public void WriteFileData(string dataText)//Используется на строке 38
        {
            try
            {
                using (FileStream fs = new FileStream(@_path, FileMode.OpenOrCreate))
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

        public void CompessFile(string dataText)
        {
            using (FileStream fs = new FileStream(_path, FileMode.OpenOrCreate))
            {
                using (FileStream ts = File.Create("out_compressed.zip"))
                {
                    using (GZipStream gzs = new GZipStream(ts, CompressionMode.Compress))
                    {
                        fs.CopyTo(gzs);
                    }
                }
            }
        }
    }
}
