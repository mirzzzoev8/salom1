﻿int a = Convert.ToInt32(Console.ReadLine());
int [] n = new int [a];
int m = 99999;
for (int i = 0; i < a; i++)
{
  n[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a; i++)
{
    if( i < m )
    {
        m=i;
        
    }
}
Console.Write(m);
