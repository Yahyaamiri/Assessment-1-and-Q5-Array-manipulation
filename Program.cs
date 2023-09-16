using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1_and_Q5_Array__manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int  i, num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;
            int[] a = new int[0];
            Console.WriteLine("your name");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("welcome: " + name);

            Console.WriteLine("Enter 10 numbers");

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());
            num5 = Convert.ToInt32(Console.ReadLine());
            num6 = Convert.ToInt32(Console.ReadLine());
            num7 = Convert.ToInt32(Console.ReadLine());
            num8 = Convert.ToInt32(Console.ReadLine());
            num9 = Convert.ToInt32(Console.ReadLine());
            num10 = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <=10; i++)
            {

               


                Console.WriteLine("Number 1 is: " +num1);
                Console.WriteLine("Number 2 is: " + num2);
                Console.WriteLine("Number 3 is: " + num3);
                Console.WriteLine("Number 4 is: " + num4);
                Console.WriteLine("Number 5 is: " + num5);
                Console.WriteLine("Number 6 is: " +num6);
                Console.WriteLine("Number 7 is: " +num7);
                Console.WriteLine("Number 8 is: " +num8);
                Console.WriteLine("Number 9 is: "  + num9);
                Console.WriteLine("Number 10 is: " + num10);
                 a = new int[] { num1,num2,num3,num4,num5,num6,num7,num8,num9,num10 };
                Console.WriteLine("The new array values are: "+a);
                Console.ReadLine();








            }






            /*
            Console.Write("Number 4 is: ");
            num4 = Convert.ToInt32(Console.ReadLine());
            manipulation = num4;
            Console.WriteLine("Number 5 is:");
            num5 = Convert.ToInt32(Console.ReadLine());
            manipulation = num5;
            Console.WriteLine("Number 6 is:");
            num6 = Convert.ToInt32(Console.ReadLine());
            manipulation = num6;
            Console.WriteLine("Number 7 is:");
            num7 = Convert.ToInt32(Console.ReadLine());
            manipulation = num7;
            Console.WriteLine("Number 8 is:");
            num8 = Convert.ToInt32(Console.ReadLine());
            manipulation = num8;
            Console.WriteLine("Number 9 is:");
            num9 = Convert.ToInt32(Console.ReadLine());
            manipulation = num9;
            Console.WriteLine("Number 10 is:");
            num10 = Convert.ToInt32(Console.ReadLine());
            manipulation = num10;
            */


            Console.ReadKey();

        }
       
              
        }
    //manipulation=num1 + num2+num3+num4+num5+num6+num7+num8+num9+num10;
    // Console.WriteLine(manipulation);
   // Console.WriteLine("Number 1 is: "+a[i]);

    }


