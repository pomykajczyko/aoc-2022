namespace Opsoft.AdventOfCode;

internal sealed class RoundWithStrategy : Round
{
    private readonly int _expectedResult;

    public RoundWithStrategy(string line) : base(line)
    {
        if (!char.TryParse(SplittedLine[1], out var expectedResultChar))
            throw new ArgumentException("Cannot parse expected result.", nameof(line));
        _expectedResult = expectedResultChar switch
        {
            'X' => ResultType.Lose,
            'Y' => ResultType.Draw,
            'Z' => ResultType.Win,
            _ => throw new ArgumentException("Wrong letter in expected result", nameof(line))
        };
    }

    public override int CalculateScore()
    {
        MyMove = MakeDecisionBasedOnExpectedResult();
        return base.CalculateScore();
    }

    private Move MakeDecisionBasedOnExpectedResult()
    {
        return _expectedResult switch
        {
            ResultType.Draw => PaperScissorsGamePolicy.GetDrawingMove(OpponentMove),
            ResultType.Lose => PaperScissorsGamePolicy.GetLosingMove(OpponentMove),
            ResultType.Win => PaperScissorsGamePolicy.GetWinningMove(OpponentMove),
            _ => throw new ArgumentException("Not available expected result")
        };
    }
}