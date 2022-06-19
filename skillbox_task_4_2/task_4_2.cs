
Console.Write("Введите длину последовательности: ");
int sequence = int.Parse(Console.ReadLine());

int[] numbArray= new int[sequence]; 

for(int i = 0; i < sequence; i++)
{
    Console.Write($"Задайте {i+1}-е число: ");
    numbArray[i] = int.Parse(Console.ReadLine());

}

//Первый способ
Array.Sort(numbArray);

Console.WriteLine(); 
Console.WriteLine($"{numbArray[0]} является наименьшим");

//Второй способ

int minValue = int.MaxValue;

for(int i = 0; i < numbArray.Length; i++)
{
    if (numbArray[i] < minValue)
    {
       minValue = numbArray[i];
    }
}

Console.WriteLine();
Console.WriteLine($"{minValue} является наименьшим");