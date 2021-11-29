﻿using Dijkstra.NET.Graph;
using Dijkstra.NET.ShortestPath;

namespace Dijkstra.Net60
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph<int, string>() + 1 + 2;

            bool connected = graph >> 1 >> 2 >> 5 ^ "edge information";

            var immutablePath = graph.Dijkstra(1, 2);

            foreach (var edge in graph >> 1)
            {
                Console.WriteLine(edge.Item);
            }
        }
    }
}
