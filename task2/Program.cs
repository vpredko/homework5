int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write(array[i] + " ");
    }
    Console.Write("] -> ");
}

int[] myArray = CreateRandomArray(10, 10, 100);
ShowArray(myArray);
int sum = 0;

for (int i = 0; i < myArray.Length; i++)

   if (i % 2 != 0)
        sum = myArray[i] + sum;

Console.WriteLine(sum);
