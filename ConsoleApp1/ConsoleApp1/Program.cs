// TASK 1

Random rand = new Random();
int[] arr = new int[10];
int ct = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(1,101);
    if ((arr[i]<91) && (arr[i] > 19))
    {
        ct++;
    };
}
Console.WriteLine(ct); // количество элементов [20,90]


////
///
///TASK 2
ct = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(1, 101);
    if (arr[i] % 2 == 0 )
    {
        ct++;
        
    };
}
Console.WriteLine(ct); // количество четных чисел


///TASK 3
///
double max = 0, min = 1000;
double[] arrd = new double[10];
for (int i = 0;i < arrd.Length; i++)
{
    arrd[i] = rand.NextDouble()*90 +10;
    if (arrd[i] > max) { max = arrd[i]; };
    if (arrd[i] < min) { min = arrd[i]; };
};

Console.WriteLine(max -  min);



///TASK 4
int c= 1,h,j = rand.Next(1, 100001);
h = j;
while (h>= 10)
{
    h /= 10;
    c++; ;
};
int[] arr4 = new int[c];
for (int i = c-1; i >= 0; i--)
{
    arr4[i] = j % 10;
    j /= 10;
};











