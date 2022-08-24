using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBox_HW_Theme_6.Handling
{
    internal class Calculate
    {
        public static int _MaxValue { get { return 1_000_000_000; } }
        public static int _MinValue { get { return 0; } }
        public static int _N { get; set; }
        public int _M { get; set; }
        private int[] _numbers;
        private int[][] _groups;

        public Calculate(int n)
        {
            _N = n;
            _groups = new int[1][];
            _groups[0] = new int[1];
            FillArrayOrdered();
        }

        private void FillArrayOrdered()
        {
            _numbers = new int[_N];
            for (int i = 0; i < _N; i++)
            {
                _numbers[i] = i + 1;
            }
        }
        public int[][] GroupOfIndivisibles(int N)
        {
            Array.Resize(ref _groups[_M], N - N / 2);
            Array.Copy(_numbers, N / 2, _groups[_M], 0, N - N / 2);
            _M++;
            if (N != 1)
            {
                Array.Resize(ref _groups, _groups.Length + 1);
                _groups[_M] = new int[1];
                GroupOfIndivisibles(N / 2);
            }
            return _groups;
        }
    }
}
