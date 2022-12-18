int[] array = { 121, 232, 233, 434, 2355, 665, 740, 8890 };

int n = array.Length;
int find = 434;

int index = 0;

while(index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
