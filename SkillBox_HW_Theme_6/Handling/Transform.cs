using System;
using System.Text;

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
                if (dataInt <= Constants._minValue || dataInt >= Constants._maxValue) { return -1; }
            }
            catch (Exception exception) { Console.WriteLine(exception.Message); }
            return dataInt;
        }

        public static string JaggedArrayToString(int[][] array)
        {
            StringBuilder sb = new StringBuilder(); //Вместо работы с string и конкатенацией, использовал
            int groupCounter = 1;                   //StringBuilder.
            foreach (var group in array)
            {
                sb.Append($"\nГруппа {groupCounter}: ");
                foreach (var number in group)
                {
                    sb.Append($"{number} ");
                }
                sb.AppendLine();
                groupCounter++;
            }
            return sb.ToString();
        }
    }
}
