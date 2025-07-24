using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_Adv_01
{
    public class Range<T> where T : IComparable<T>, INumber<T>
    {
        
        public T Min { get; set; }
        public T Max { get; set; }
        public Range(T _Max, T _Min)
        {
            Min = _Min;
            Max = _Max;
        }

        public bool IsInRange(T Val)
        {
            return Min.CompareTo(Val) <=0 && Max.CompareTo(Val) >= 0;
        }

        
        public int Length(T max, T min)
        {
            return int.CreateChecked(max - min);
        }

    }
}
