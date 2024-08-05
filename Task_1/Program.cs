// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.
void Main()
{
int numberM = ReadInt("Введите значение M: ");
int numberN = ReadInt("Введите значение N: ");
PrintNaturalNumbers(numberM, numberN);
}

void PrintNaturalNumbers(int current, int N)
{
if(current >  N) return;
{
    System.Console.Write(current + " ");
    PrintNaturalNumbers(current + 1, N);
}
}

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine());
}

Main();
