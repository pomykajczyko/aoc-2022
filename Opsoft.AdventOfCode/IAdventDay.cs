namespace Opsoft.AdventOfCode;

public interface IAdventDay<out TDay, out TFirstAnswerType, out TSecondAnswerType>
{
    TFirstAnswerType GetPartOneAnswer();
    TSecondAnswerType GetPartTwoAnswer();
}