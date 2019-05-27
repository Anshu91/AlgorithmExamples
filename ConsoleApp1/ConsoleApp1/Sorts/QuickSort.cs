using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sorts
{
    class QuickSort : ISort
    {
        public void Sort(int[] arr)
        {
            int pivot;
            int left = 0, right = arr.Length - 1;
            QuickSortWrapper(arr, left, right);
        }

        private void QuickSortWrapper(int[] arr, int low, int high)
        {
            int pivot;
            if(low<high)
            {
                pivot = QPartititon(arr, low, high);
                QuickSortWrapper(arr, low, pivot - 1);
                QuickSortWrapper(arr, pivot + 1, high);
            }
        }

        private int QPartititon(int[] arr, int low, int high)
        {
            int left = low;
            int right = high;
            int pivot = arr[left];
            Console.WriteLine("pivot=" + pivot);
            foreach(var e in arr)
            {

                Console.Write(e + ", ");
            }
            Console.WriteLine();
            while (left<right)
            {
                while((left<right)&&(arr[left]<=pivot))
                {
                    left++;
                }
                while ((left < right) && (arr[right] > pivot))
                {
                    right--;
                }
                Console.WriteLine("left=" + left + "right=" + right);
                if(left<right)
                swap(arr, left, right);

            }
            //most imp
            arr[low] = arr[right-1];
            arr[right-1] = pivot;
            foreach (var e in arr)
            {

                Console.Write(e + ", ");
            }
            Console.WriteLine();
            return right;
        }

        private void swap(int[] arr, int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }
}
