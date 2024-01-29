Console.WriteLine("Введите 2 числа");
int a=Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("Числа равны");
}
else if (a > b)
{
    Console.WriteLine("a больше b");
}
else if (a < b)
{
    Console.WriteLine("a меньше b");
}