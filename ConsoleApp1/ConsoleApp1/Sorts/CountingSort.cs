using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sorts
{
    class CountingSort : ISort
    {
        public void Sort(int[] arr, int k)
        {
            int n = arr.Length;
            int[] sortedArray = new int[n];
            int[] temp = new int[k];
            for(int i =0;i<k;i++)
                temp[i] = 0;
            for(int i =0;i<n;i++)
            {
                temp[arr[i]]++;
            }
            for (int i = 1; i < k; i++)
            {
                temp[i]=temp[i-1]+temp[i];
                Console.WriteLine($"cf for {i} ={temp[i]} ");
            }
            for (int i =0;i<n;i++)
            {
                //most imp
                sortedArray[temp[arr[i]]-1] = arr[i];
                temp[arr[i]]--;
            }
            Console.WriteLine();
            for(int i =0;i<n;i++)
            {
                Console.Write(sortedArray[i] + ", ");
            }
            Console.WriteLine();
            Array.Copy(sortedArray, arr, n);
        }

        internal void Sort(int[] arr, int v, int power)
        {
            int[] count = new int[v];
            for(int i =0;i<v;i++)
            {
                count[i] = 0;
            }
            for(int i =0;i<arr.Length;i++)
            {
                count[(arr[i] / power) % 10]++;
            }
            Console.WriteLine("count array,power=" + power);
            for (int i = 0; i < count.Length; i++)
            {
                Console.Write(count[i] + ",,");
            }
            
            for (int i =1;i<v;i++)
            {
                count[i] = count[i] + count[i - 1];
            }
            Console.WriteLine("count array,power=" + power);
            for (int i = 0; i < count.Length; i++)
            {
                Console.Write(count[i] + ",");
            }
            int[] output = new int[arr.Length];
            //most imp
            for(int i =arr.Length-1;i>=0;i--)
            {
                output[count[(arr[i] / power) % 10]-1] = arr[i];
                count[(arr[i] / power) % 10]--;
            }
            //Console.WriteLine("input array,power="+power);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + ",,");
            //}
            //Console.WriteLine("output array");
            //for (int i =0;i<arr.Length;i++)
            //{
            //    Console.Write(output[i] + ",,");
            //}
            Array.Copy(output, arr, arr.Length);
        }

        public void Sort(int[] arr)
        {
            throw new NotImplementedException();
        }
    }
}
