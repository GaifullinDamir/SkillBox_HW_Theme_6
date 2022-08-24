using SkillBox_HW_Theme_6.Handling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillBox_HW_Theme_6.Infrastructure;

namespace SkillBox_HW_Theme_6.UI
{
    public class Input
    {
        public static void InputPath()
        {
            Console.Write("Введите адрес файла:");
            FileProcessing.SetPath(Console.ReadLine()); 
        }

        public static int InputInteger()
        {
            string dataText; bool stop = false;
            int dataInt = -1;
            while(!stop)
            {
                dataText = Console.ReadLine();
                dataInt = Transform.StringToInt(dataText);
                stop = dataInt == -1 ? false : true;
            }
            return dataInt;
        }

        public static bool InputChange()
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
