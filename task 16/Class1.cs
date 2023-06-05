using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_16
{
    internal class Class1
    {
        public int MinValue(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
        public int MaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        public int MinimumIndex(int[] array)
        {
            int min = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (min < array[i])
                {
                    min = array[i];
                    index = i;
                }
            }
            return min;
        }
        public int MaxIndex(int[] array)
        {
            int max = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max > array[i])
                {
                    max = array[i];
                    index = i;
                }
            }
            return max;
        }
        public int SumOfArrayElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;

        }
        public int[] ReverseArray(int[] array)
        {
            int[] a = new int[array.Length];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                a[array.Length - i - 1] = array[i];
            }

            return a;
        }
        public int CountElements(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public int[] ReverseHalfMassive(int[] array)
        {
            int mid = array.Length / 2;
            int tmp = 0;
            int start = mid;
            if (array.Length % 2 != 0)
                start++;
            for (int i = 0; i <mid; i++)
            { 
               tmp = array[start+i];
                array[start+i] = array[i];
                array[i] = tmp;
            }
            return array;
        }
        

         
        
    }
}


