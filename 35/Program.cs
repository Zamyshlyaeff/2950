// Подсчитать сумму цифр в числе. Сделать подпрограмму.
int A=0;
int Summ(int N)
{  while (N!=0)
   { 
     A=A+N%10;
     N=N/10;
   }
   return A;
}
Console.WriteLine(Summ(23457));