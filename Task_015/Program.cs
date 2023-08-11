/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int Promt(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool Weekend(int weekday)
{
    if (weekday > 5)
    {
        return true;
    }
    return false;
}
bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Такого дня недели нет");
    return false;
}

int weekday = Promt("Введите день недели цифрой ");
if (ValidateWeekday(weekday))
{
    if (Weekend(weekday))
    {
        Console.WriteLine("Это выходной");
    }
    else
    {
        Console.WriteLine("Это не выходной");
    }
}