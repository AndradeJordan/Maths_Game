using System;


namespace Jeu_de_Maths
{
    public static class Displayer
    {
        public static void ask_your_name()
        {
            Console.WriteLine("What's your name ?");
        }
        public static void Welcome_player(string name)
        {
            Console.WriteLine($"Welcome {name} !!! :D ");
        }

        public static void ask_question(int i)
        {
            Console.WriteLine("Question number : "+i);
        }

        public static void displayer_ask_number_condition()
        {
            Console.WriteLine("Sorry you need to enter an integer ");
        }

        public static void checking_value(bool value)
        {
            if (value)
            {
                Console.WriteLine(" Good answer !!! ;)");
            }
            else
            {
                Console.WriteLine("Sorry :( Bad answer !!!");
            }
        }
    }

}
