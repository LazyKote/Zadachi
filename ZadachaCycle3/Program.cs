while (true)
{
    Console.WriteLine("Введите число:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите еще одно число:");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
    {
        Console.WriteLine("Введенные числа недопустимы. Введите числа ещё раз.");
    }
    else
    {
        int result = num1 * num2;
        Console.WriteLine("Результат умножения:"+result);
        break;
    }
}