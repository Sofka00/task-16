using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Class1 class1 = new Class1();
            int[] array = new int[] { 1, 2, 3 ,4};
            
            int[] X = class1.ReverseHalfMassive (array);
            Console.WriteLine(X);
            
        }
       
        

    }
}

