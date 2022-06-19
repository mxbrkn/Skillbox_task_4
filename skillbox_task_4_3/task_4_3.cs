// See https://aka.ms/new-console-template for more information
Console.WriteLine("*********** Добро пожаловать в игру УГАДАЙ ЧИСЛО ***********");
Console.WriteLine();
Console.Write("Будем отгадывать от 0 до ");

int limit = int.Parse(Console.ReadLine());

Random random = new Random();

int guessNumber = random.Next(0, limit+1);


int t = 0; 
while (true)
{
    Console.WriteLine();
    Console.WriteLine("Ваше предположение: ");

    //if (Console.ReadKey().Key == ConsoleKey.Enter)
    //{
    //    Console.WriteLine($"Было загадано {guessNumber}");
    //    break;
    //}

    int userNumber = int.Parse(Console.ReadLine());
    t++;
    if (guessNumber > userNumber)
    {

        Console.WriteLine("Загаданное число больше");
    }
    else if (guessNumber < userNumber)
    {
        Console.WriteLine("Загаданное число меньше");
    }
    else
    {
        Console.WriteLine($"Вы угадали с {t}-й попытки!");
        break;
    }
}
