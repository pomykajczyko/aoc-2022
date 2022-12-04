namespace Opsoft.AdventOfCode;

internal abstract class Round
{
    protected Move OpponentMove;
    protected Move? MyMove;
    protected readonly string[] SplittedLine;

    protected Round(string line)
    {
        SplittedLine = line.Split(' ');
        OpponentMove = new Move(SplittedLine[0]);
        MyMove = new Move(SplittedLine[1]);
    }

    public virtual int CalculateScore()
        => CalculateRoundResult() + (int)MyMove!.Value;

    private int CalculateRoundResult()
    {
        var roundResult =
            MyMove == OpponentMove ? ResultType.Draw : GetResultForOpponentShape();
        if (roundResult == -1) throw new Exception("Something gone wrong");
        return roundResult;
    }

    private int GetResultForOpponentShape()
    {
        if (MyMove is null)
            throw new NullReferenceException("Move cannot be null");
        return MyMove.Value ==
               PaperScissorsGamePolicy.GetWinningMove(OpponentMove)
            ? ResultType.Win
            : ResultType.Lose;
    }
}