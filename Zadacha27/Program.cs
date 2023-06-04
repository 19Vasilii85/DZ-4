Console.Clear();
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;
int num = Convert.ToInt32(number);
int sum = 0; 
for (int i = 1; i <= len; i++) {
    sum += num % 10;
    num /= 10; 
}
Console.WriteLine($"сумма числа: {number} равно: {sum}");
