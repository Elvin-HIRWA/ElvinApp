using System;

namespace ElvinApp
{
   
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter 3 numbers");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(c); 
            Addmulti addmulti = new Addmulti();
            addmulti.y(a, b, c);
        }

    }
    }

    
