using System;

namespace Lab_6_HW_Raheel_Khan
{
    class Program
    {
        
        public static int GetDice(int Dice)
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, Dice + 1);
            return num1;         
        }

        static void Main(string[] args)
        {
            string answer = "";
            string answer2 = "";
            bool i = true;

            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n)");
            answer = Console.ReadLine();
           
            if (answer == "y" || answer == "Y")
            {              
                Console.WriteLine("How many sides should each die have?");

                do
                {                   
                    int Dice = int.Parse(Console.ReadLine());

                    int output1 = GetDice(Dice);
                    int output2 = GetDice(Dice);

                    Console.WriteLine("Role 1:\n{0}\n{1}", output1, output2);
                    Console.WriteLine("Roll again?(y/n):...");
                    answer2 = Console.ReadLine();

                    if (answer2 == "y" || answer2 == "Y")
                    {
                        i = true;
                        Console.WriteLine("How many sides should each die have?");
                    }
                    if (answer2 == "n" || answer2 == "N")
                    {
                        i = false;
                        Console.WriteLine("GoodBye");
                    }
                } while (i == true);
            }   
            
        }
    }
}
