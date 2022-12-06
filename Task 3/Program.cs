// Программа на входе принимает число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 7 == 0 && N % 23 == 0)
{
    Console.WriteLine("Число одновременно кратно 7 и 23: ");
}
else
{
    Console.WriteLine("Число одновременно не кратно 7 и 23: ");
}