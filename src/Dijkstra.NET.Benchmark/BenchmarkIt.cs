﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using Dijkstra.NET.PageRank;
using Dijkstra.NET.ShortestPath;

namespace Dijkstra.NET.Benchmark
{
    [SimpleJob(RunStrategy.Monitoring, launchCount: 1, warmupCount: 2, targetCount: 3)]
    [MemoryDiagnoser]
    public class BenchmarkIt : BenchmarkBase
    {
        public BenchmarkIt()
        {
        }

        [GlobalSetup]
        public void Initialise()
        {
            Console.WriteLine("--- Global Setup ---");
            InitialiseGraph();
        }

        [IterationSetup]
        public void IterationSetup()
        {
            Console.WriteLine("--- Iteration Setup ---");
        }

        [Benchmark(Baseline = true)]
        public int DijkstraExtensionBenchmark()
        {
            var result = Graph.Dijkstra(BenchmarkBase.First, BenchmarkBase.Last);

            return result.GetPath().Count();
        }

        [Benchmark]
        public double PageRankExtensionBenchmark()
        {
            var result = Graph.PageRank();

            return result[BenchmarkBase.First];
        }
    }
}