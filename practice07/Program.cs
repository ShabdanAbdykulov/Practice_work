// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели : ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber)
{
    if(dayNumber == 6 || dayNumber == 7 )
    {
        System.Console.WriteLine("Этот день выходной!");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        System.Console.WriteLine("Это не день недели.");
    }
    else System.Console.WriteLine("Этот день не выходной.");
}
CheckingTheDayOfTheWeek(dayNumber);