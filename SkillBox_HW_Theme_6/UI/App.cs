using System;
using System.Diagnostics;
using SkillBox_HW_Theme_6.Handling;
using SkillBox_HW_Theme_6.Infrastructure;

namespace SkillBox_HW_Theme_6.UI
{
    internal class App
    {
        private string _path = String.Empty;

        private void ShowMainMenu()
        {
            Console.WriteLine(
                "0.Меню\n" 
               +"1. Показать количество групп\n"
               +"2. Записать группы в файл\n"
               +"3. Завершить работу\n");
        }        
        private int ReadFromFile()
        {
            FileProcessing fp = new FileProcessing();
            int dataInt = Transform.StringToInt(fp.ReadFileData());
            if(dataInt == -1)
            {
                Console.WriteLine("В файле находится неверное значение.");
                return -1;
            }
            return dataInt;
        }
        private int[][] ComputeForCase()
        {
            int dataInt = ReadFromFile();
            Computing calculate = new Computing(dataInt);
            return calculate.GroupOfIndivisibles(dataInt);
        }
        private void CaseShowGroupsCount()
        {
            Input.InputPath();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine($"Количество групп: {ComputeForCase().Length}");
            stopwatch.Stop();
            Console.WriteLine($"Время затраченное на выполнение: {stopwatch.Elapsed}");
        }
        private void CaseWriteToFile()
        {
            Console.WriteLine("Адрес для получения данных");
            Input.InputPath();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileProcessing fp = new FileProcessing();
            string result = Transform.JaggedArrayToString(ComputeForCase());
            Console.WriteLine("Адрес для выгрузки данных");
            Input.InputPath();
            fp.WriteFileData(result);
            stopwatch.Stop();
            Console.WriteLine($"Время затраченное на выполнение: {stopwatch.Elapsed}");
            Console.WriteLine("Зархивировать данные?");
            if(Input.InputChange())
            {
                Console.WriteLine("Адрес файла который нунжо заархивировать");
                Input.InputPath();
                fp.CompessFile(result);
            }
        }

        public void AppCycle()
        {
            ShowMainMenu();
            bool stop = false;
            while(!stop)
            {
                switch (Input.InputInteger())
                {
                    case 1:
                        CaseShowGroupsCount(); break;
                    case 2:
                        CaseWriteToFile(); break;
                    case 3:
                        stop = true; break;
                    default:
                        Console.WriteLine("Такого пункта меню нет."); break;
                }
            }
        }
    }
}
