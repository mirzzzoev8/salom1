int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int cnt = 1;

for (int i = a; i>0; i/=10)
{
    sum +=i%10; cnt *=i%10;
}
System.Console.WriteLine("SUMMA = " + sum);

System.Console.WriteLine("ZARBW = " + cnt);

