// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
/*
void ShowNum (int n)
{
    if(n > 1) ShowNum (n - 1)
    Console.Write(n + " ");
}

ShowNum();
*/

//Задача 66:Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
void SumDigit (int m,int n)
{
    if(n > m)
    {
        SumDigit(m -1,n);
        Console.Write(m + " ");
    }
    if(n < m)
    {
        SumDigit(n - 1, m);
        Console.Write(n + " ");
    }
}

int m = 1;
int n = 5;
SumDigit(m,n);
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Accerman (int m,int n)
{
    if(n == 0)
        return m + 1;
    else
    if (n != 0)
      return Accerman(n - 1, 1);
    if(m == 0)
        return Accerman(n - 1, Accerman(n, m - 1));
    else
        return 0;
    
}
int m = 2;
int n = 3;

Console.WriteLine(Accerman(m,n));