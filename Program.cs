// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите размер массива и мы заполним его чем попало:)");
int size = 0;
int sizeRange = 100;
if (Int32.TryParse(Console.ReadLine(), out size))
{
    int[] arrRandom = new int[size];
    FillArray(arrRandom,sizeRange);
    PrintArray(arrRandom);
}
else
{
    Console.WriteLine("Необходимо ввести цифры!");
    return;
}

// Functions
// заполнение массива
void FillArray(int[] arrayIn,int range)
{
    Random rnd = new Random();
    for (int i = 0; i < arrayIn.Length; i++)
    {
        arrayIn[i] = rnd.Next(0,range);
    }
}

// печать массива
void PrintArray(int[] arrayIn)
{
    for(int i = 0; i < arrayIn.Length; i++)
    {
        if (i == 0)
            Console.Write($"[{arrayIn[i]}, ");
        else if (i == arrayIn.Length-1)
            Console.Write($"{arrayIn[i]}]");
        else
            Console.Write($"{arrayIn[i]}, ");
    }
}