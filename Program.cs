// задать массив из 12 элементов, заполненных числами из (0,9)
// найти сумму положительных элементов массива
// найти сумму отрицательных элементов массива
int[]arr=new int [12];
for (int i=0; i<arr.Length; i++)
{
    arr[i]=new Random().Next(0,9);
    Console.Write($" {arr[i]} "); // задать массив из 12 элементов, заполненных числами из (0,9)
}
Console.WriteLine();
int sum=0;
for (int i=0; i<arr.Length; i++)
{
    if (arr[i]> 0)
    {
        sum=sum+arr[i];
        
    }
}
 Console.WriteLine(sum);// найти сумму положительных элементов массива
 Console.WriteLine();
int sum1=0;
for (int i=0; i<arr.Length; i++)
{
    if (arr[i]< 0)
    {
        sum1=sum1+arr[i];
        
    }
}
Console.WriteLine(sum1);// найти сумму отрицательных элементов массива