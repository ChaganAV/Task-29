// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите размер массива и мы заполним его чем попало:)");
Console.WriteLine("А потом посмотрим, что из этого получится:)");
int size = 0;
if (Int32.TryParse(Console.ReadLine(), out size))
{

}
else
{
    Console.WriteLine("Необходимо ввести цифры!");
    return;
}

// Functions
int[] FillArray(int[] arrayIn)
{
    for (int i = 0; i < arrayIn.Length; i++)
    {
        
    }
    return arrayIn;
}
