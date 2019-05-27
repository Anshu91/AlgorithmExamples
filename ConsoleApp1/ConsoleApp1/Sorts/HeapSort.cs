using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sorts
{
    class HeapSort : ISort
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;
            for(int i =n/2-1;i>=0;i--)
            {
                //2most imp
                Heapify(arr, i,n);
            }
            SortHeap(arr);

        }

        private void SortHeap(int[] arr)
        {
            int n = arr.Length;
            List<int> temp = new List<int>();
            for(int i =n-1;i>=0;i--)
            {
                //most imp
                temp.Add(arr[0]);
                int v = arr[0];
                arr[0] = arr[i];
                arr[i] = v;

                Heapify(arr, 0, i);
            }
            foreach(var ele in temp)
            {
                Console.Write(ele + ",");
            }
            Console.WriteLine();

        }

        private void Heapify(int[] arr, int i, int n)
        {
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            int largest = i;
            if ((r<n)&&(arr[largest] < arr[r]))
                largest = r;
            if ((l<n)&&(arr[largest] < arr[l]))
                largest = l;
            if(largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;
                Heapify(arr, largest,n);
            }
        }
    }
}
