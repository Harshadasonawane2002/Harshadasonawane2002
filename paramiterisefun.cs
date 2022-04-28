#program to demonstrate  parameterize function in c#.net.
using System;
namespaceCSharp_Shell
{
           Public class Program 
    {  
Int x=0;
    Void print(intx,int y)
	{
		x=x+y;
	Console.WriteLine(x);
	}
        Public static void Main()
     {
	Program p=new Program();
p.print(5,5);
           }    }}
