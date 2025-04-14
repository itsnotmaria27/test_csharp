Random r = new Random();
int rInt = r.Next(0, 10);
int tries = 1;

for (int i = 0; i < 4; i++)
{
    tries++;
    if(tries < 4)
    {
        Console.WriteLine("Введите предполагаемое число от 1 до 10");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num == rInt)
        {
            Console.WriteLine("Your super puper mega ultra");
            break;
        }
        if (num >= rInt)
        {
            Console.WriteLine("Загаданное число меньше");
        }
        if (num <= rInt)
        {
            Console.WriteLine("Загаданное число больше");
        }
    }   
    if (tries == 4)
    {
        Console.WriteLine("Game over");
    }
}
Console.ReadKey();
