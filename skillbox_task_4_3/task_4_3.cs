// See https://aka.ms/new-console-template for more information
Console.WriteLine("*********** Добро пожаловать в игру УГАДАЙ ЧИСЛО ***********");
Console.Write("\nБудем отгадывать от 0 до ");

Random random = new Random();
int limit = int.Parse(Console.ReadLine());
int guessNumber = random.Next(0, limit+1);
int t = 0; // номер попытки 'try'
int userNumber;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Для выхода в любой момент нажмите Enter");
Console.ForegroundColor = ConsoleColor.White;

while (true)
{
    Console.WriteLine("\nВаше предположение: ");
    try 
    {
        userNumber = Convert.ToInt32(Console.ReadLine());
    }
    catch 
    {
        Console.WriteLine($"Было загадано {guessNumber}");
        break;
    }
 

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
