int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a = 29;
int b = 38;
int c = 45;
int d = 17;
int e = 36;
int f = 54;
int g = 82;
int h = 73;
int i = 19;

int max1 = Max(a, b, c);
int max2 = Max(d, e, f);
int max3 = Max(g, h, i);
int max = Max(max1, max2, max3);


Console.WriteLine(max);