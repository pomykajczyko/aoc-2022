using System.Collections.Generic;
using System.Linq;

namespace Opsoft.AdventOfCode;

internal sealed class Day1 : AdventDay<int, int>
{
    private readonly List<int> _elvesCaloriesSum;
    public Day1(List<string> lines)
    {
        Lines = lines;
        _elvesCaloriesSum = GetSummedElvesCaloriesAscending();
    }

    private List<int> GetSummedElvesCaloriesAscending()
    {
        var elvesSummerCalories = new List<int>();
        var aggregateCalories = 0;
        foreach (var line in Lines)
        {
            if (!string.IsNullOrEmpty(line) && int.TryParse(line, out var tempValue)) aggregateCalories += tempValue;
            else
            {
                elvesSummerCalories.Add(aggregateCalories);
                aggregateCalories = 0;
            }
        }

        elvesSummerCalories.Sort();
        return elvesSummerCalories;
    }
    public override int GetPartOneAnswer()
    => _elvesCaloriesSum.Last();

    public override int GetPartTwoAnswer()
    => _elvesCaloriesSum.TakeLast(3).Sum();
}