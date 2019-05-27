using Priority_Queue;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Graphs
{
    class edge: FastPriorityQueueNode
    {
        public int src;
        public int dest;
        public int weight;
    }
    class DirectedGraph
    {
        int[] Distance;
        vertex[] vertices;
        List<edge>[] edges;
        public DirectedGraph(int v)
        {
            vertices = new vertex[v];
            edges = new List<edge>[v];
            Distance = new int[v];
            for (int i = 0; i < v; i++)
            {
                Distance[i] = 9999;
                vertices[i] = new vertex();
                vertices[i].label = i;
                vertices[i].visited = false;
                edges[i] = new List<edge>();
            }
        }

        public void AddEdge(int s, int d, int w)
        {
            var newEdge = new edge();
            newEdge.src = s;
            newEdge.dest = d;
            newEdge.weight = w;

            edges[s].Add(newEdge);
        }

        public void Dijkstra(int start)
        {
            var curr = vertices[start];
            Console.WriteLine("visited =" + curr.label);
            Distance[curr.label] = 0;
            Priority_Queue.FastPriorityQueue<vertex> pq = new FastPriorityQueue<vertex>(10);
            pq.Enqueue(curr, 0);
            while (pq.Count > 0)
            {
                var next = pq.Dequeue();
                Console.WriteLine("visited =" + next.label + " at weight =" + next.Priority);
                Distance[next.label] = (int)next.Priority;
                var nextneighbouredges = edges[next.label];

                for (int i = 0; i < nextneighbouredges.Count; i++)
                {
                    if (Distance[nextneighbouredges[i].dest] > next.Priority + nextneighbouredges[i].weight)
                        pq.Enqueue(vertices[nextneighbouredges[i].dest], nextneighbouredges[i].weight + next.Priority);
                }
            }
        }

        public void Primsmst(int start)
        {
            var curr = vertices[start];
            Console.WriteLine("visited =" + curr.label);
            Distance[curr.label] = 0;
            Priority_Queue.FastPriorityQueue<vertex> pq = new FastPriorityQueue<vertex>(10);
            pq.Enqueue(curr, 0);
            while (pq.Count > 0)
            {
                var next = pq.Dequeue();
                Console.WriteLine("visited =" + next.label + " at weight =" + next.Priority);
                Distance[next.label] = (int)next.Priority;
                var nextneighbouredges = edges[next.label];

                for (int i = 0; i < nextneighbouredges.Count; i++)
                {
                    if (Distance[nextneighbouredges[i].dest]> next.Priority+nextneighbouredges[i].weight)
                        pq.Enqueue(vertices[nextneighbouredges[i].dest], nextneighbouredges[i].weight);
                }
            }

        }
    }
}
