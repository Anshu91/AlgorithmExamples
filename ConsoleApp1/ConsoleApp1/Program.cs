using ConsoleApp1.Sorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Graphs;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 12, 31, 11, 5, 9, 45 };
            //int[] countingsortdata = { 9, 5, 3, 7, 2, 1 };
            //Print(arr);
            ////var algo = new CountingSort();
            ////algo.Sort(countingsortdata, 10);
            ////var algo = new BucketSort();
            ////algo.BSort(countingsortdata, 10);
            //var algo = new RadixSort();
            //algo.Sort(arr);
            //Print(arr);
            //Graph obj = new Graph(10);
            //obj.AddEdge(1, 2);
            //obj.AddEdge(2, 3);
            //obj.AddEdge(2, 4);
            //obj.AddEdge(3, 5);
            //obj.AddEdge(3, 6);
            //obj.AddEdge(4, 7);
            //obj.AddEdge(4, 8);
            //obj.AddEdge(5, 9);
            //obj.AddEdge(9, 1);
            //Console.WriteLine("BFS begins");
            //obj.BST(1);
            //Console.WriteLine("DFS begins");
            //obj.DFS(1);
            var directedmst = new DirectedGraph(10);
            directedmst.AddEdge(1, 2,10);
            directedmst.AddEdge(2, 3,50);
            directedmst.AddEdge(2, 4,5);
            directedmst.AddEdge(3, 5,10);
            directedmst.AddEdge(3, 6,10);
            directedmst.AddEdge(4, 7,10);
            directedmst.AddEdge(4, 8,10);
            directedmst.AddEdge(5, 9,10);
            directedmst.AddEdge(9, 1,10);
            directedmst.Primsmst(1);
            Console.Read();
        }

        private static void Print(int[] arr)
        {
            foreach(var x in arr)
            {
                Console.Write(x + ",");
            }
            Console.WriteLine();
        }
    }
}
