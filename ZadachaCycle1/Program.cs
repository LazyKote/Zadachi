Console.WriteLine("Введите сумму вклада");
decimal dep=Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Введите количество месяцев");
int months=Convert.ToInt32(Console.ReadLine());
for(int i=0; i<months; i++)
{
    dep += dep * 0.07m;
}
Console.WriteLine("Конечная сумма:" + dep);