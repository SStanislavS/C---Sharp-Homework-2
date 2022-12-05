// Программа на входе принимает трехзначное число, а на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
string N = Console.ReadLine();
Console.Write("Вторая цифра: ");
Console.WriteLine(N[N.Length - 2]);
