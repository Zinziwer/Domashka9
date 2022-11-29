//Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
void Zadacha68()
{
    uint n = 2;
    uint m = 3;
    if (n >= 0 && m >= 0) Console.WriteLine(Akk(n, m));
    else Console.WriteLine("Impossible");
}

uint Akk(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0)) return Akk(n - 1, 1);
    else return Akk(n - 1, Akk(n, m - 1));
}
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
void Zad66()
{
    Console.Clear();
    Random random = new Random();
    int m = random.Next(5, 10);
    int n = random.Next(10, 30);
    Console.WriteLine($"{m}  {n}");
    Console.WriteLine();
    if (n > m) Console.WriteLine(Rekurs1(n, m));
    else Console.WriteLine("Impossible");
}

int Rekurs1(int number, int start = 1, int sum = 0)
{
    if (start > number) return sum;
    sum = sum + start;
    start++;
    return Rekurs1(number, start, sum);
}
//Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который
// выведет все натуральные числа кратные 3-ём в промежутке от M до N.
void Zadacha64()
{
    Console.Clear();
    Random random = new Random();
    int number1 = random.Next(5, 40);
    int number2 = random.Next(30, 101);
    Console.WriteLine($"{number1}  {number2}");
    Console.WriteLine();
    if (number2 > number1) Rekurs2(number2, number1);
    else Console.WriteLine("Impossible");
}
void Rekurs2(int number, int start = 1)
{
    if (start > number) return;
    if (start % 3 == 0) Console.Write(start + "  ");
    start++;
    Rekurs2(number, start);
}
//Zadacha64();
Zadacha68();
//Zad66();