using System;

namespace hw_for_5_28_19
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            Console.WriteLine("Life is like a box of chocolate..You're never going to know what you're going to get.");
            Console.WriteLine("How happy are you today on a scale of 1-3? 1 being the highest and 3 being the lowest.");
            answer = Console.ReadLine();

            switch(answer)
            {
                case "1":

                    string people = Method1(2);
                    Console.WriteLine(people);
                    break;
                case "2":
                    string ok = Method2("Be strong. Because things will get better.", "It may be stormy now, but it never rains forever");
                    Console.WriteLine(ok);
                    break;
                case "3":
                    Method3();
                    break;




                default:
                    Console.WriteLine("Be happy.");
                    break;
                    
            }



        }


        
        private static string Method1(int happy)
        {


            Console.WriteLine("This is how happy you are!");


            for (int x = 0; x < happy; x++)
            {
                Method1(x);
            }
            return "GO AND MAKE OTHERS AS HAPPY AS YOU!";

   

        }


        
        private static string Method2 (string one, string two )
        {
            Console.WriteLine("This is for you:");
            string quote = one + two;
            return quote;
        }


        
        private static void Method3()
        {
            Console.WriteLine("Yesterday is not ours to recover, but tomorrow is ours to win.");
        }



    }
}
