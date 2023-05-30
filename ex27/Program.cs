Console.WriteLine("Введите число. Программа посчитает сумму цифр в нем");
int digit1 = int.Parse(Console.ReadLine());
void FindDigitsSum (int digit)
{
int res = 0;
while (digit > 0)
{
    res = digit % 10 + res;
    digit = digit / 10;
}
Console.WriteLine(res);
}
FindDigitsSum(digit1);