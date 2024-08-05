// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
void Main()
{
    int number_m = ReadInt("Введите значение m: ");
    int number_n = ReadInt("Введите значение n: ");
    System.Console.WriteLine(Ackermann(number_m, number_n));
}

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine());
}

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
Main();
// В Википедии в таблице перепутаны местами n и m.
