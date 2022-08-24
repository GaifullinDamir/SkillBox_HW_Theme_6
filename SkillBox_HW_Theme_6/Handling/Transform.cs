using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillBox_HW_Theme_6.Service;

namespace SkillBox_HW_Theme_6.Handling
{
    internal class Transform
    {
        public static int StringToInt(string dataText)
        {
            int dataInt = -1;
            try
            {
                dataInt = int.Parse(dataText);
                if (dataInt <= Calculate._MinValue || dataInt >= Calculate._MaxValue) { return -1; }
            }
            catch (Exception exception) { Console.WriteLine(exception.Message); }
            return dataInt;
        }

        public static string JaggedArrayToString(int[][] array)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string result = string.Empty;
            int groupCounter = 1;
            foreach (var group in array)
            {
                result += $"\nГруппа {groupCounter}: ";
                foreach (var number in group)
                {
                    result += $"{number} ";
                }
                result += "\n";
                groupCounter++;
            }
            return result;
        }
    }
}
