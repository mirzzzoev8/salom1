int a;
 int cnt = 0;
 int sum = 0;

for(;;)
{  
    a = Convert.ToInt32(Console.ReadLine());
    if(a == 0) break;
    sum += a;
    cnt++;

}
System.Console.Write("Total sum  ");

System.Console.WriteLine(sum);

System.Console.Write("Total amount ");

System.Console.WriteLine(cnt);