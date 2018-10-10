using System;

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Question1();
            //Question2();
            //Question3();
            //Question4();
            Question5();
        }
        /*
        static void Question1()
        {
            int answer = 2;
            Console.Write("Question 1: Growing up, how many times did Christina's house catch fire?\n" + "(Hint: It was less than 5 times!)\n");
            int guess = Convert.ToInt32(Console.ReadLine());

            try
            {
                if(guess > 5)
                {
                    throw (new ArgumentOutOfRangeException());
                } 

                if(guess == answer)
                {
                    Console.WriteLine("Great guess!");
                }
                else
                {
                    Console.WriteLine("Aw, wrong guess! Her house set on fire twice.");
                }
            }

            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("error: {0}", e.Message);
            }

            finally
            {
                Console.WriteLine("Christina's mom is known for being an unintentional arsonist!");
            } 
        }  

        
        static void Question2()
        {
            try
            {
                Console.WriteLine("Question 2: Is Mr. Rogers one of Christina's heroes-- true or false?");
                bool answer = Boolean.Parse(Console.ReadLine());
                
                if(answer == true)
                {                  
                    Console.WriteLine("You\'re right!");
                }
                else
                {
                    Console.WriteLine("Sorry, wrong guess!");
                }

            }

            catch (FormatException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }

            finally
            {
                Console.WriteLine("Make sure to check out the acclaimed documentary \"Won't You Be My Neighbor\"!");
            }

        }
        
        
        static void Question3()
        { 
            string answer = "no";
            Console.Write("Question 3: Does Christina have any natural survival instincts?");
            string guess = Console.ReadLine();

            if(guess == answer)
            {
                Console.WriteLine("You're absolutely correct. She can\'t swim OR camp!");
            }
            else
            {
                Console.WriteLine("Incorrect! She can\'t swim OR camp!");
            }   
        }
    
        static bool Question4()
        {
            bool answer = true;
            Console.WriteLine("Question 4: Christina was once bitten by an ostrich-- true or false?");
            bool guess = Boolean.Parse(Console.ReadLine());

          
            if (guess == answer)
            {
                return true;
            }
            else
            {
                return false;
            }                         
        }
       */
        static void Question5()
        {
            string answer = "Argentina";
            Console.WriteLine("In which country was Christina born?");
            string guess = Console.ReadLine();

            if(guess == answer)
            {
                Console.WriteLine("Great guess! You are correct.");
            }
            else
            {
                Console.WriteLine("Wrong, she was born in Argentina!");
            }
        }   
    }
}
