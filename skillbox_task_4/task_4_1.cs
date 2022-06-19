Console.Write("Введите количество строк матрицы: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int collums = int.Parse(Console.ReadLine());

Console.WriteLine(); //перенос строки добавим для красоты

int[,] matrix  = new int[rows, collums];

Random random = new Random();

int sum = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < collums; j++)
    {
        matrix[i, j] = random.Next(100);
        Console.Write($"{matrix[i, j]} ");

        sum += matrix[i, j];
    }

    Console.WriteLine();
}
Console.WriteLine(); //перенос строки добавим для красоты

Console.WriteLine($"Сумма всех чисел матрицы: {sum}");
Console.ReadKey();