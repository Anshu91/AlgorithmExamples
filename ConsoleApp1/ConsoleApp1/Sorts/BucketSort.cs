using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Sorts
{
    class BucketSort : ISort
    {
        public void Sort(int[] arr)
        {
            throw new NotImplementedException();
        }
        public void BSort(int[] arr, int k)
        {
            var buckets = new int[k];
            for(int i =0;i<k;i++)
            {
                buckets[i] = 0;
            }
            for(int i =0;i<arr.Length;i++)
            {
                buckets[arr[i]]++;
            }
            int c = 0;
            for(int i =0;i<k;i++)
            {
                //most imp
                while(buckets[i]>0)
                {
                    arr[c++] = i;
                    buckets[i]--;
                }
            }
        }
    }
}
