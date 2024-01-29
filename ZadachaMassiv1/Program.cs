string[] strings = { "Фрукт", "Планета", "Цветок", "Фильм", "Животное", "Время" };

Console.Write("Введите строку: ");
string  str= Console.ReadLine();

bool found = false;

foreach (string stri in strings)
{
    if (stri == str)
    {
        found = true;
        break;
    }
}

if (found)
{
    Console.WriteLine("Строка найдена!");
}
else
{
    Console.WriteLine("Строка не найдена!");
}
