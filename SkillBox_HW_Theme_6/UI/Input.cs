using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBox_HW_Theme_6.UI
{
    internal class Input
    {
        private const int _maxValue = 1_000_000_000;
        private const int _minValue = 0;

        public static int InputInteger()
        {
            string dataText; bool stop = false;
            int dataInt = -1;
            while(!stop)
            {
                dataText = Console.ReadLine();
                dataInt = Convert(dataText);
                stop = dataInt == -1 ? false : true;
            }
            return dataInt;
        }

        public static int Convert(string dataText)
        {
            int dataInt = -1;
            try
            {
                dataInt = int.Parse(dataText);
                if (dataInt <= _minValue || dataInt >= _maxValue){ return -1; }
            }
            catch (Exception exception) { Console.WriteLine(exception.Message); }
            return dataInt;
        }

        public static bool Change()
        {
            Console.WriteLine("Введите: y(да) или n(нет)"); string dataText = String.Empty;
            while (dataText != "y" && dataText != "n")
            {
                Console.WriteLine("y или n");
                dataText = Console.ReadLine();
            }
            return dataText == "y" ? true : false;
        }
    }
}
