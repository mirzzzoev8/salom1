int n; 
int max=-999999; 
 
for(;;) 
{ 
    n = Convert.ToInt32(Console.ReadLine()); 
    if(n == 0 )break; 
    if(n > max)max=n; 
 
} 
 
Console.WriteLine(max);
