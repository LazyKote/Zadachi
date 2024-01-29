int[] array= { 3, 5, 6, 7, 8 };
int sum = 0;

foreach (int num in array)
{
    sum += num;
}

double srednee = (double)sum / array.Length;

Console.WriteLine("Сумма: " + sum);
Console.WriteLine("Среднее арифметическое значение: " + srednee);
