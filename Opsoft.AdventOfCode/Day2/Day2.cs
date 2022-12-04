namespace Opsoft.AdventOfCode;

internal sealed class Day2 : AdventDay<int, int>
{
    private readonly IEnumerable<string> _lines;

    public Day2(IEnumerable<string> lines)
    {
        _lines = lines;
    }

    public override int GetPartOneAnswer()
        => GetTournamentScore<RoundWithMoves>();

    public override int GetPartTwoAnswer()
        => GetTournamentScore<RoundWithStrategy>();

    private int GetTournamentScore<TRound>() where TRound : Round
        => new Tournament<TRound>(_lines).GetSummaryScore();
}