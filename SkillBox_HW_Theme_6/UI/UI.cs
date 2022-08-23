using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBox_HW_Theme_6.UI
{
    internal class UI
    {
        private int _n;
        private string _path;

        public void ShowMainMenu()
        {
            Console.WriteLine(
                "");
        }
        public void InputPath()
        {
            Console.WriteLine("Введите адрес файла");
            Console.WriteLine("Показать пример ввода?");
            _path = Console.ReadLine();

        }
        
    }
}
