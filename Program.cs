Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= n; i+=2)
{
if (i == n || i == n - 1)
Console.Write(i);
else
Console.Write(i + ", ");
}

