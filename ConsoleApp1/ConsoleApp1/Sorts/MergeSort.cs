using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sorts
{
    class MergeSort : ISort
    {
        //private int[] result = new int[1000];
        public void Sort(int[] arr)
        {
            DivideAndMerge(arr, 0, arr.Length-1);
            int n = arr.Length;
            //Array.Copy(result, arr, n);
        }

        private void DivideAndMerge(int[] arr, int start, int end)
        {
            if (start >= end)
                return;

            int mid = start + (end - start) / 2;
            Console.WriteLine("start=" + start + " mid=" + mid + " end = " + end);
            DivideAndMerge(arr, start, mid);
            DivideAndMerge(arr, mid + 1, end);
            int firtstart = start;
            int secondstart = mid + 1;
            Console.WriteLine("firststart=" + firtstart + " mid=" + mid + " end = " + end+"secodstart="+secondstart);
            Console.WriteLine("Merging 1st array=");
            for(int i =start;i<=mid;i++)
            {
                Console.Write(arr[i] + ",");

            }
            Console.WriteLine();
            Console.WriteLine("Merging 2nd array=");
            for (int i = mid+1; i <= end; i++)
            {
                Console.Write(arr[i] + ",");

            }
            Console.WriteLine();
            int[] temp = new int[end - start + 1];
            for (int i =0;i<end-start+1;i++)
            {
                if (firtstart > mid)
                {
                    while (secondstart <= end)
                    {
                        temp[i++] = arr[secondstart++];
                    }
                    continue;
                }
                if (secondstart >end)
                {
                    while(firtstart<=mid)
                    {
                        temp[i++] = arr[firtstart++];
                    }
                    continue;
                }
                if (arr[firtstart]<arr[secondstart])
                {
                    temp[i] = arr[firtstart];
                    firtstart++;
                }
                else
                {
                    temp[i] = arr[secondstart];
                    secondstart++;
                }
            }
            for(int i =0;i<end-start+1;i++)
            {
                Console.Write(temp[i] + ",");
            }
            Console.WriteLine();
            //most imp
            Array.Copy(temp,0, arr, start, end-start+1);
        }
    }
}
