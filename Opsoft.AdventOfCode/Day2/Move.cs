using System;

namespace Opsoft.AdventOfCode;

internal record Move
{
    public Shape Value { get; }
    public Move(string moveInput)
    {
        if (!char.TryParse(moveInput, out var moveChar)) throw new ArgumentException("Cannot parse move.");
        switch (moveChar)
        {
            case 'A':
            case 'X':
                Value = Shape.Rock;
                break;
            case 'B':
            case 'Y':
                Value = Shape.Paper;
                break;
            case 'C':
            case 'Z':
                Value = Shape.Scissors;
                break;
        }
    }

    public Move(Shape shape)
    {
        Value = shape;
    }
    public static implicit operator Shape(Move move)
        => move.Value;
}