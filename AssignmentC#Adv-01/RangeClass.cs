using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_Adv_01
{
    public class RangeClass<T> where T : INumber<T>
    {
        
        public T Min { get; set; }
        public T Max { get; set; }
        public RangeClass()
        {
            
        }
        public RangeClass(T _Max, T _Min)
        {
            Min = _Min;
            Max = _Max;
        }

        public T[] BubbleSort(T[] arr)
        {
            bool swapped;
            for (int i = 0; i < arr.Length; i++)
            {
                swapped = false;
                for(int j = 0 ; j < arr.Length - i - 1; j++)
                {
                    if(arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        T tmp = arr[j]; 
                        arr[j] = arr[j + 1]; 
                        arr[j + 1] = tmp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
            return arr;
        }

        public bool IsInRange(T Val)
        {
            return Min.CompareTo(Val) <= 0 && Max.CompareTo(Val) >= 0;
        }

        public T Length(T max, T min)
        {
            return max - min;
        }

    }
}
