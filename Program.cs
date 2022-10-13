string[] array = { "Russia", "157", "-2", "computer science" };
int count = array.Length;
string[] newArray = new string[count];
int j = 0;
for (int index = 0; index < count; index++)
{
    int strLen = array[index].Length;
    if (strLen <= 3)
    {
        newArray[j] = array[index];
        j++;
    }
}
for (int index = 0; index < j; index++)
{
    if (index == j - 1) //Проверка на последний элемент, при выводе не было лишних запятых
    {
        Console.Write(newArray[index]);
    }
    else
    {
        Console.Write($"{newArray[index]}, ");
    }
}