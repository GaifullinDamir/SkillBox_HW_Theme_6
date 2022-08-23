using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillBox_HW_Theme_6.Service;

namespace SkillBox_HW_Theme_6.UI
{
    internal class UI
    {
        private int _n;
        private string _path;

        public void ShowMainMenu()
        {
            Console.WriteLine(
                "1. Показать количество групп"
               +"2. Записать группы в файл");
        }
        public void InputPath()
        {
            Console.WriteLine("Показать пример ввода?");
            if (Input.Change())
            {
                Console.WriteLine(@"C: \Users\Damir\source\repos\SkillBox_HW_Theme_6\SkillBox_HW_Theme_6\In.xlsx");
            }
            Console.Write("Введите адрес файла:");
            _path = Console.ReadLine();
        }
        
        public void Read()
        {
            FileProcessing fileProcessing = new FileProcessing();
            int dataInt = Transform.StringToInt(fileProcessing.ReadFileData(_path));
            if(dataInt == -1)
            {
                Console.WriteLine("В файле находится неверное значение.");
                return;
            }
            Console.WriteLine($"{dataInt}");


        }
    }
}
