using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Jeu_de_Maths
{
    public static class my_tools
    {
        enum e_Operator
        {
            ADDITION = 1,
            SUBTRACTION = 2,
            TIMES = 3,
            MODULO = 4
            //DIVISION = 4,
            //DOUBLE_DIVISION = 5,
            
        }
        public static string ask_your_name()
        {
            Displayer.ask_your_name();
            string name = Console.ReadLine();
            return name;
        }


        public static int generate_expression(int min_val, int max_val)
        {
            int a = 0, b=0;
            Random random = new Random();
            a = random.Next(min_val,max_val);
            b = random.Next(min_val, max_val);

            e_Operator operator_choose = (e_Operator)random.Next(1,5);
            int expected_result;

            switch (operator_choose)
            {
                case e_Operator.ADDITION:
                    Console.WriteLine(a + "+" + b + " = ");
                    expected_result = a + b;
                    break;

                case e_Operator.SUBTRACTION:
                    Console.WriteLine(a + "-" + b + " = ");
                    expected_result = a - b;
                    break;

                case e_Operator.TIMES:
                    Console.WriteLine(a + "*" + b + " = ");
                    expected_result = a * b;
                    break;

                case e_Operator.MODULO:
                    Console.WriteLine(a + "%" + b + " = ");
                    expected_result = a % b;
                    break;

                default:
                    Console.WriteLine("missing Operator");
                    return 0;

            }
            return expected_result;

        }
        public static int ask_result_user()
        {
            int result_user = 0;
            bool condi = true;
            while (condi)
            {
                string result_user_string = Console.ReadLine();

                try
                {
                    result_user = int.Parse(result_user_string);
                    condi = false;

                }
                catch
                {
                    Displayer.displayer_ask_number_condition();
                    condi = true;
                }

            }
            return result_user;

        }

        public static bool check_solutions(int user_result,int expected_result)
        {
            if (user_result == expected_result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
