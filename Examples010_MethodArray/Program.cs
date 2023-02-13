int[] array = {1, 21, 33, 4, 8, 52, 6, 57, 8};

int n = array.Length;
int find = 8;

int index = 0;

while( index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}