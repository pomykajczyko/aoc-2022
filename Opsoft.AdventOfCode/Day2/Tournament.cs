namespace Opsoft.AdventOfCode;

internal sealed class Tournament<TRound>
    where TRound : Round
{
    private readonly IEnumerable<TRound> _rounds;

    public Tournament(IEnumerable<string> rounds)
    {
        _rounds = rounds.Select(line => (TRound)Activator.CreateInstance(typeof(TRound), line)!);
    }

    public int GetSummaryScore()
        => _rounds.Select(x => x.CalculateScore()).Sum();
}