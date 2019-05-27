using System;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1
{
    internal class InsertionSort: ISort
    {
        public InsertionSort()
        {
        }

        public void Sort(int[] arr)
        {
            int n = arr.Length;
            for(int j = 1; j<n; j++)
            {
                int current = 0;
                while ((current<n)&&(arr[j]>arr[current]))
                {
                    current++;
                }
                if(current<n)
                {
                    InsertBefore(arr, j, current);
                }
            }
        }

        private void InsertBefore(int[] arr, int j, int current)
        {
            int value = arr[j];
            while(j>current)
            {
                //most imp
                arr[j] = arr[j - 1];
                j--;
            }
            arr[j] = value;
        }
    }
}