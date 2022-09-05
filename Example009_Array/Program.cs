// Array
// Create Function to fill Array:
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// Method for printing array (void -- no return):
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// Method for finding index of array element which = 'find'
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    // Write '-1' if there is no element equil to 'find'
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

// Create new massive with 10 elements:
int[] array = new int[10];

FillArray(array);

array[4] = 4;
array[7] = 4;

PrintArray(array);
// Print empty line after array:
Console.WriteLine();

int pos = IndexOf(array, 44);
Console.WriteLine(pos);

// int[] array = { 3, 5, 6, 22, 45, 52, 6, 34, 45 };

// int n = array.Length;
// int find = 6;

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }
