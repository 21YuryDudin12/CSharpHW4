Console.WriteLine("Введите число а, которое нужно возвести в степень, затем введите степень, в которую нужно возвести число");
int qa = int.Parse(Console.ReadLine());
int qb = int.Parse(Console.ReadLine());
int FindDigitSt (int a, int b)
{
int res = a;
int i = 0;
for (i = 2; i <= b; i++)
{
res = res *a;
}
return res;
}
FindDigitSt(qa, qb);
Console.WriteLine(FindDigitSt(qa, qb));

