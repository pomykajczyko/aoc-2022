using System;

namespace Opsoft.AdventOfCode;

internal static class PaperScissorsGamePolicy
{
    public static Move GetWinningMove(Move opponentMove)
    {
        return opponentMove.Value switch
        {
            Shape.Rock => new Move(Shape.Paper),
            Shape.Paper => new Move(Shape.Scissors),
            Shape.Scissors => new Move(Shape.Rock),
            _ => throw new ArgumentOutOfRangeException(nameof(opponentMove), "Not available move")
        };
    }

    public static Move GetLosingMove(Move opponentMove)
    {
        return opponentMove.Value switch
        {
            Shape.Rock => new Move(Shape.Scissors),
            Shape.Paper => new Move(Shape.Rock),
            Shape.Scissors => new Move(Shape.Paper),
            _ => throw new ArgumentOutOfRangeException(nameof(opponentMove), "Not available move")
        };
    }

    public static Move GetDrawingMove(Move opponentMove) => opponentMove;
}