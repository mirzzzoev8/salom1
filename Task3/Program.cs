int n;  
int cnt = 0;
int sum=0;
 
for(;;) 
{ 
    n = Convert.ToInt32(Console.ReadLine()); 
    sum+=n;
    if(n == 0 )
    cnt++;
    if(cnt>=2)
    break;

} 
 
Console.WriteLine(sum);
