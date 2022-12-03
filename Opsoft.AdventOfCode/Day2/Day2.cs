using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Opsoft.AdventOfCode;
internal sealed class Day2 : AdventDay<int, int>
{
    private readonly IEnumerable<string> _lines;

    public Day2(IEnumerable<string> lines)
    {
        _lines = lines;
    }

    public override int GetPartOneAnswer()
    {
        var tournamentPartOne = new Tournament<RoundWithMoves>(_lines);
        return tournamentPartOne.GetSummaryScore();
    }

    public override int GetPartTwoAnswer()
    {
        var tournamentPartTwo = new Tournament<RoundWithStrategy>(_lines);
        return tournamentPartTwo.GetSummaryScore();
    }
}