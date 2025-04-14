Console.WriteLine("Введите верхнюю границу диапазона:");
string input = Console.ReadLine();
int range;
Random r = new Random();

if (string.IsNullOrEmpty(input))
{
    range = 10;
}
else
{
    range = Convert.ToInt32(input);
}

int rInt = r.Next(0, range);
Console.WriteLine($"Загадано число от 0 до {range-1}.");

int maxTries = (int)Math.Ceiling(Math.Log2(range));
Console.WriteLine($"У тебя есть {maxTries} попыток.");

bool guessed = false;
int lastGuess = -1; 

for (int tryCount = 1; tryCount <= maxTries; tryCount++)
{
    Console.WriteLine($"\nПопытка {tryCount}. Введи число:");
    int num;

    while (!int.TryParse(Console.ReadLine(), out num) || num < 0 || num >= range)
    {
        Console.WriteLine($"Введи нормальное число от 0 до {range - 1}!");
    }

    if (num == lastGuess)
    {
        Console.WriteLine("Одинакоыое число.");
        tryCount--; 
        continue;
    }

    lastGuess = num;

    if (num == rInt)
    {
        Console.WriteLine("Your super puper mega ultra");
        guessed = true;
        break;
    }

    if (num > rInt)
    {
        Console.WriteLine("Загаданное число меньше.");
    }
    else
    {
        Console.WriteLine("Загаданное число больше.");
    }
}

if (!guessed)
{
    Console.WriteLine($"\nGame over. Было загадано: {rInt}.");
}

Console.WriteLine("\nНажми любую кнопку, чтобы выйти...");
Console.ReadKey();