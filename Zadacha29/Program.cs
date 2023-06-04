Console.Clear();
Console.WriteLine("Нажмите Enter для создания массива и 8ми элементов");
int number = 8;
int[] array = new int[number];
for (int i = 0; i < number; i++)
{
    array[i] = new Random().Next(number);
    Console.Write(array[i] + "; ");
}
Console.WriteLine();
