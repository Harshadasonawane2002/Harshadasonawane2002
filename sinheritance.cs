# Program To demonstrate simple inheritance in c#.net.
using System;
Namespace CSharp_Shell
{
Public class Program 
    {
    Public	introllno=107;
     Public string	name=”harshali”;
    }
    Class exam:Program
    {
  Public static void Main()
        {
	Exam n=new exam();
Console.WriteLine(n.rollno);
Console.WriteLine( n.name);
	Console.ReadLine();
        }
    }
}


