namespace Opsoft.AdventOfCode;

public abstract class AdventDay<TFirstAnswerType, TSecondAnswerType> : IAdventDay<
    AdventDay<TFirstAnswerType, TSecondAnswerType>, TFirstAnswerType, TSecondAnswerType>
{
    protected List<string> Lines = new();

    public static async Task<List<string>> Initialize(string filePath)
    {
        var path = Path.Combine(Environment.CurrentDirectory, filePath);
        if (!File.Exists(path)) throw new FileNotFoundException($"File with name {filePath} not found.");
        var lines = await File.ReadAllLinesAsync(path);
        return lines.ToList();
    }

    public abstract TFirstAnswerType GetPartOneAnswer();
    public abstract TSecondAnswerType GetPartTwoAnswer();
}