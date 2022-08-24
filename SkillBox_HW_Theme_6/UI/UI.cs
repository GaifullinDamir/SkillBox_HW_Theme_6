using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillBox_HW_Theme_6.Handling;
using SkillBox_HW_Theme_6.Service;

namespace SkillBox_HW_Theme_6.UI
{
    internal class UI
    {
        private string _path = String.Empty;

        private void ShowMainMenu()
        {
            Console.WriteLine(
                "0.Меню" 
               +"1. Показать количество групп"
               +"2. Записать группы в файл"
               +"3. Завершить работу");
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
            Calculate calculate = new Calculate(dataInt);
            return calculate.GroupOfIndivisibles(dataInt);
        }
        private void CaseShowGroupsCount()
        {
            Console.WriteLine($"Количество групп: {ComputeForCase().Length}");
        }
        private void CaseWriteToFile()
        {
            FileProcessing fp = new FileProcessing();
            string result = Transform.JaggedArrayToString(ComputeForCase());
            fp.WriteFileData(result);
        }

        public void AppCycle()
        {
            Input.Path();
            ShowMainMenu();
            bool stop = false;
            while(!stop)
            {
                switch (Input.Integer())
                {
                    case 0:
                        ShowMainMenu(); break;
                    case 1:
                        CaseShowGroupsCount(); break;
                    case 2:
                        CaseWriteToFile(); break;
                    default:
                        break;
                }
            }
        }
    }
}
