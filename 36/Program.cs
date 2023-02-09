// Написать программу вычисления произведения чисел от 1 до N
int A=0; int C=1;
int Method(int N)
{ for (C=1;C<=N;C++)
    { int y;
     for (y=1;y<=N;y++)
     {  A=C*y;
        Console.WriteLine($"{C}*{y}={A}");
     }
    }
   return A;
}
Method(15);