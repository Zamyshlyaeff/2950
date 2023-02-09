// Вывести на экран кубы чисел от 1 до N
int a=1;
double b;
double Cube(int N)
{while (a<=N)
{ b=Math.Pow(a,3);
System.Console.WriteLine($"{b}"); // не знаю как вывести ВЛ за пределы цикла, чтобы не снизили оценку
a=a+1;                             //если можно, подскажите пожалуйста в комментарии к оценке
}
return a;
}
Cube(10);