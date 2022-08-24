using System;
using System.Diagnostics;
using SkillBox_HW_Theme_6.Handling;
using SkillBox_HW_Theme_6.Service;

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
            //Создавать класс внутри другого класса некорректно, так как ты явно связываешь два класса
            //Рекумендуется создать интерфейс для работы с чтением/записью данных и реализовать этот интерфейс каким-нибудь классом
            //А здесь использовать объект интерфейса(передавать в качестве параметра конструктора!), тогда твоему классу будет пофиг откуда ты работаешь с данными(из файла, из БД, API)
            //Тем самым Мы делаем приложение слабосвязанным
            //Читать про Dependency Injection
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
            Calculate calculate = new Calculate(dataInt); //То же самое, что и выше
            return calculate.GroupOfIndivisibles(dataInt);
        }
        private void CaseShowGroupsCount()
        {
            Input.Path();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine($"Количество групп: {ComputeForCase().Length}");
            stopwatch.Stop();
            Console.WriteLine($"Время затраченное на выполнение: {stopwatch.Elapsed}");
        }
        private void CaseWriteToFile()
        {
            Console.WriteLine("Адрес для получения данных");
            Input.Path();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileProcessing fp = new FileProcessing();
            string result = Transform.JaggedArrayToString(ComputeForCase());
            Console.WriteLine("Адрес для выгрузки данных");
            Input.Path();
            fp.WriteFileData(result);
            stopwatch.Stop();
            Console.WriteLine($"Время затраченное на выполнение: {stopwatch.Elapsed}");
            Console.WriteLine("Зархивировать данные?");
            if(Input.Change())
            {
                Console.WriteLine("Адрес файла который нунжо заархивировать");
                Input.Path();
                fp.CompessFile(result);
            }
        }

        public void AppCycle()
        {
            ShowMainMenu();
            bool stop = false;
            while(!stop)
            {
                switch (Input.Integer())
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
