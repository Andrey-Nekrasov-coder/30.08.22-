Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int c = Convert.ToInt32(Console.ReadLine());
if ((a > b ) && (b > c))
Console.WriteLine((a,b,c) + "->"+ a);
if ((b > a ) && (a > c))
Console.WriteLine((a,b,c) + "->"+ b);
if ((c > b ) && (b > a))
Console.WriteLine((a,b,c) + "->"+ c);
