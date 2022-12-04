using System.Diagnostics;
using System.Runtime.CompilerServices;
using Opsoft.AdventOfCode;

[assembly: InternalsVisibleTo("Opsoft.AdventOfCode.Tests")]

var elapsedTime = new Stopwatch();
elapsedTime.Start();

#region Day1

var day1 = new Day1(await Day1.Initialize(Path.Combine("day1", "day1input.txt")));
Console.WriteLine($"Day 1 part one answer: {day1.GetPartOneAnswer()}");
Console.WriteLine($"Day 1 part two answer: {day1.GetPartTwoAnswer()}");

#endregion

#region Day2

var day2 = new Day2(await Day2.Initialize(Path.Combine("day2", "day2input.txt")));
Console.WriteLine($"Day 2 part one answer: {day2.GetPartOneAnswer()}");
Console.WriteLine($"Day 2 part two answer: {day2.GetPartTwoAnswer()}");

#endregion

elapsedTime.Stop();
Console.WriteLine($"Elapsed time: {elapsedTime.Elapsed}");