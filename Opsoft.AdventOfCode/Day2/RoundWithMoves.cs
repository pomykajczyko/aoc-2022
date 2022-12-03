namespace Opsoft.AdventOfCode;

internal sealed class RoundWithMoves : Round
{
    public RoundWithMoves(string line) : base(line)
    {
        OpponentMove = new Move(SplittedLine[0]);
        MyMove = new Move(SplittedLine[1]);
    }
}