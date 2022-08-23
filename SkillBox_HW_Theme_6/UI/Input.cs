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
            string input; bool stop = false;
            int integer = -1;
            while (!stop)
            {
                try
                {
                    input = Console.ReadLine();
                    integer = int.Parse(input);
                    if(integer >= _minValue && integer <= _maxValue)
                    {
                        stop = true;
                    }
                    else Console.WriteLine("Число не попадает в границы.");
                    
                }
                catch (Exception)
                {
                    Console.Write("Введите целое число: ");
                }
            }
            return integer;
        }
    }
}
