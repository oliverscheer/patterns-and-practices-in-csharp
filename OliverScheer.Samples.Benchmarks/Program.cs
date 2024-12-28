// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using OliverScheer.Samples.PeriodicElementNameGenerator;

Console.WriteLine("Hello, Benchmarks!");

var summary = BenchmarkRunner.Run<LoopBenchmarks>();
