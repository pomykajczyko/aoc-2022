using System.Collections.Generic;
using FluentAssertions;

namespace Opsoft.AdventOfCode.Tests;

public class Day2Tests
{
    [Fact]
    public void Day2PartOneFixedResultCheck()
    {
        var lines = new List<string>
        { "A Y", "B X", "C Z" };
        var day2 = new Day2(lines);
        var score = day2.GetPartOneAnswer();
        score.Should().Be(15);
    }

    [Fact]
    public void Day2PartTwoFixedResultCheck()
    {
        var lines = new List<string>
        { "A Y", "B X", "C Z" };
        var day2 = new Day2(lines);
        var score = day2.GetPartTwoAnswer();
        score.Should().Be(12);
    }
}