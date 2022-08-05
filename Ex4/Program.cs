// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
  int n = 1;
  Console.WriteLine("Введите конец диапазона N");
  int N = int.Parse(Console.ReadLine());
  for (int i = n; i <= N; i++)
  {
    if (i % 2 == 0)
     Console.Write(i + " ");
     }

