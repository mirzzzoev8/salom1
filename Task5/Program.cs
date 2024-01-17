int  n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [n]; 
int min=999999999, mn=1;

for(int i=0; i<n; i++)
{
  arr[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i=0; i<n; i++)
{
  if(arr[i] < min) 
  {
    min= arr[i];
    mn= i;
  }
}

Console.WriteLine(mn);