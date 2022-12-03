using System;

namespace Opsoft.AdventOfCode;

internal abstract class Round
{
    protected Move OpponentMove;
    protected Move? MyMove;
    protected string[] SplittedLine;

    protected Round(string line)
    {
        SplittedLine = line.Split(" ");
        OpponentMove = new Move(SplittedLine[0]);
        MyMove = new Move(SplittedLine[1]);
    }
    
    public virtual int CalculateScore()
    {
        var totalScore = 0;
        totalScore += CalculateRoundResult();
        totalScore += (int)MyMove!.Value;
        return totalScore;
    }
    private int CalculateRoundResult()
    {
        var roundResult = -1;
        if (MyMove == OpponentMove) roundResult = ResultType.Draw;
        else
            roundResult = OpponentMove.Value switch
            {
                Shape.Rock => GetResultForOpponentShape(Shape.Paper),
                Shape.Paper => GetResultForOpponentShape(Shape.Scissors),
                Shape.Scissors => GetResultForOpponentShape(Shape.Rock),
                _ => roundResult
            };
        if (roundResult == -1) throw new Exception("Something gone wrong");
        return roundResult;
    }
    private int GetResultForOpponentShape(Shape winningShape)
    {
        if (MyMove is null) throw new NullReferenceException("Move cannot be null");
        return MyMove.Value == winningShape ? ResultType.Win : ResultType.Lose;
    }
}