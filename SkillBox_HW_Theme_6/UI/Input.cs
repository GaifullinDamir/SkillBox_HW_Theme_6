﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBox_HW_Theme_6.UI
{
    internal class Input
    {
        

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
