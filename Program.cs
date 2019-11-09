using System;
using System.Collections;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 11, 22, 1, 5 };

            IEnumerator ie = arr.GetEnumerator(); 
            while (ie.MoveNext())   
            {
                int item = (int)ie.Current;     
                Console.WriteLine(item);
            }
            ie.Reset(); 
            Console.Read();
        }
    }
}