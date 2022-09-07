Console.Write("Введите первое число : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число : ");
int k = Convert.ToInt32(Console.ReadLine());
int max = n; 
if (n > max) max = n;
if (i > max) max = i; 
if (k > max) max = k;
    Console.Write("max = ");
    Console.WriteLine(max);

