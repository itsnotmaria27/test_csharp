using ConsoleApp1;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите верхнюю границу диапазона:");
        string input = Console.ReadLine();
        int range = string.IsNullOrEmpty(input) ? 10 : int.Parse(input);

        Console.WriteLine("Выберите сложность (Easy/Medium/Hard):");
        Difficulty difficulty = Enum.Parse<Difficulty>(Console.ReadLine(), ignoreCase: true);

        var settings = new GameSettingsBuilder()
            .WithRange(range)
            .WithDifficulty(difficulty)
            .Build();

        var game = new NumberGuesser(settings);
        game.StartGame();

        Console.WriteLine("\nНажми любую кнопку, чтобы выйти...");
        Console.ReadKey();
    }
}

