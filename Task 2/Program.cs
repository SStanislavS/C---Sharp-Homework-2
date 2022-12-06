// Программа на входе принимает число, а на выходе показываает третью цифру заданного числа или сообщает, что цифры нет.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 99)
{
    Console.WriteLine("Третьей цифры нет: ");
}
if (N > 99)
{
    Console.Write("Третья цифра: ");
    Console.WriteLine(N.ToString()[2]);
}