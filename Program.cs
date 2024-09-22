using System;
using System.Threading;

class Program
{
    static void Main()
    {
      Console.Write("name: ");
        string Name =Console.ReadLine();
         Console.Write("password: ");
        string pass = Console.ReadLine();

        int t = 0;
       
       Console.WriteLine("Welcome boss");
        while (true)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            t++;

            if (name == Name && password == pass)
            {
                Console.WriteLine("great");
                break;
            }
            else
            {
                Console.WriteLine("wrong.");

                if (t < 3)
                {
                    Console.WriteLine("wait 10 seconds.");
                    Thread.Sleep(10000);
                }
                else
                {
                    Console.WriteLine("Your time has finished.");
                    break;
                }
            }
        }
    }


}