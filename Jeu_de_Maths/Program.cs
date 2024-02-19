using System;
using System.Data;

namespace Jeu_de_Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER_TOTAL_QUESTION = 10;
            const int MIN_VAL = -10;
            const int MAX_VAL = 100;
            int cp_true = 0;
            string my_name = my_tools.ask_your_name();
            Displayer.Welcome_player(my_name);
            for (int i = 1; i<=NUMBER_TOTAL_QUESTION; i++)
            {
                Displayer.ask_question(i);
                int result_expected =my_tools.generate_expression(MIN_VAL, MAX_VAL);
                int result_user = my_tools.ask_result_user();
                
                bool value_checking = my_tools.check_solutions(result_expected, result_user);
                
                Displayer.checking_value(value_checking);
                if (value_checking)
                {
                    cp_true = cp_true + 1;
                }
                else
                {
                    Console.WriteLine($"True answer {result_expected}");
                }
                
            }
            double note = (double)cp_true / NUMBER_TOTAL_QUESTION;
            Console.WriteLine("Your final Level :" + (note * 100) + " %");
            
        }
    }
}
