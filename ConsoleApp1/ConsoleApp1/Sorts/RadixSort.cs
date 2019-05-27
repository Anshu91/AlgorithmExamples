using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sorts
{
    class RadixSort : ISort
    {
        public void Sort(int[] arr)
        {
            int max = arr[0];
            for (int i =1;i<arr.Length;i++)
            {
                max = max > arr[i] ? max : arr[i];
            }
            var cs = new CountingSort();
            for(int i =1;max/i>0 ;i*=10)
            {
                cs.Sort(arr, 10, i);
                Console.WriteLine("i=" + i);
                print(arr);
            }

        }

        private void print(int[] arr)
        {
            for(int i =0;i<arr.Length;i++)
            {
                Console.Write(arr[i] + "=");
            }
            Console.WriteLine();
        }
    }
}
