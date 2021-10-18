using System;

namespace Homework._4
{
    class Program
    {
        static void Main(string[] args)

        {
           
            Console.WriteLine("Input Month No.:  ");
            int number = Convert.ToInt32(Console.ReadLine());


            switch(number)
            {
                case 1:
                    Console.Write("January has 31 days\n");
                    break;
                case 2:
                    Console.Write("February has 28 days\n");
                    break;
                case 3:
                    Console.Write("March has 31 days\n");
                    break;
                case 4:
                    Console.Write("April has 30 days\n");
                    break;
                case 5:
                    Console.Write("May has 31 days\n");
                    break;
                case 6:
                    Console.Write("June has 30 days\n");
                    break;
                case 7:
                    Console.Write("July has 31 days\n");
                    break;
                case 8:
                    Console.Write("August has 31 days\n");
                    break;
                case 9:
                    Console.Write("September has 30 days\n");
                    break;
                case 10:
                    Console.Write("October has 31 days\n");
                    break;
                case 11:
                    Console.Write("November has 30 days\n");
                    break;
                case 12:
                    Console.Write("December has 31 days\n");
                    break;
                default:
                    Console.Write("Invalid Month number. \nPlease try again ....\n");
                    break;

                                                    }
            
            Console.ReadLine();
            


        }

    }
}
