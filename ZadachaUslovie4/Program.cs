Console.WriteLine("Введите сумму вклада");
double dep = Convert.ToDouble(Console.ReadLine());

double percent;
if (dep < 100)
{
    percent = 0.05;
}
else if (dep <= 200)
{
    percent = 0.07;
}
else
{
    percent = 0.1;
}

double deposittot = dep + (dep * percent);

Console.WriteLine("Конечная сумма вклада: " + deposittot);