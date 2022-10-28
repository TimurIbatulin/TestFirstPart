string [] array = new string [5];
string [] arr = new string [5];
for (int i=0; i<5; i++)
{
    Console.Write($"Введите {i+1} значение массива: ");
    array[i] = Console.ReadLine();
}
int count=0;
for (int j=0; j<5; j++)
{
    if (array[j].Length <=3)
    {
        arr[count]=array[j];
        count++;
    }
}
for (int h=0; h<count; h++)
{
    Console.Write($"{arr[h]} | ");
}