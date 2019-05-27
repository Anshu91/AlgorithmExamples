using Priority_Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Graphs
{
    public class vertex : FastPriorityQueueNode
    {
        public int label;
        public bool visited;
    }
    class Graph
    {
        vertex[] vertices;
        List<int>[] edges;
        public Graph(int v)
        {
            vertices = new vertex[v];
            for(int i = 0;i<v;i++)
            {
                vertices[i] = new vertex();
                vertices[i].visited = false;
                vertices[i].label = i;
            }
            edges = new List<int>[v];
        }
        
        public void AddEdge(int source,int dest)
        {
            if(edges[source]== null)
            edges[source] = new List<int>();
            edges[source].Add(dest);
        }

        public void BST(int start)
        {
            var v = vertices[start];
            Queue<vertex> bstq = new Queue<vertex>();
            bstq.Enqueue(v);
            while(bstq.Count!=0)
            {
                var curr = bstq.Dequeue();
                curr.visited = true;
                Console.WriteLine("visited vertex=" + curr.label);

                //Add all neighbour to queue
                var neighbours = edges[curr.label];
                if(neighbours!= null)
                for(int i =0;i<neighbours.Count;i++)
                {
                    var neighbour = neighbours[i];
                    if(vertices[neighbour].visited == false)
                    bstq.Enqueue(vertices[neighbour]);
                }
            }

        }

        public void DFS(int start)
        {
            var v = vertices[start];
            if(v!= null)
            {
                v.visited = true;
                Console.WriteLine("visited=" + v.label);
                var neighbours = edges[v.label];
                if(neighbours!=null)
                for(int i =0;i<neighbours.Count;i++)
                {
                        var nextvertex = neighbours[i];
                        if(vertices[nextvertex] != null)
                        {
                            if (vertices[nextvertex].visited == false)
                                DFS(nextvertex);
                        }

                }
            }
        }
    }
}
