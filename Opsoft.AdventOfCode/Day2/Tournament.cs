using System;
using System.Collections.Generic;
using System.Linq;

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
    {
        var scores = _rounds.Select(x => x.CalculateScore());
        return scores.Sum();
    }
    
    
}