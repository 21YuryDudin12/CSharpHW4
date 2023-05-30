Console.WriteLine("Программа задает массив из 8 элементов и выводит их на экран");
void NewArray8()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        int a = new Random().Next(1, 100);
        array[i] = a;
        Console.WriteLine(array[i]);
    }
}
NewArray8(); 
