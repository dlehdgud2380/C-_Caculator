using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator_Ver2
{
    class Program
    {
        static int Plus(int a, int b)
        {
            return a + b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }

        static int Multiplex(int a, int b)
        {
            return a * b;
        }

        static void Divide(int a, int b, out int Quotient, out int Remainder)
        {
            Quotient = a / b;
            Remainder = a % b;
        }


        static void Main(string[] args)
        {

            string Power_Method;

            string Calculate_Method;
            int Calculate_Method_Number;

            string input_x, input_y;
            int x, y;
            int Remain_Result;
            int Result;

            Console.WriteLine("Caculator 0.2 by SCOUTLEE\n\n\n\n\n\n");
            Console.Write("계산기를 시작하시겠습니까? Y/N :");
            Power_Method = Console.ReadLine();

            while (Power_Method=="y")
            {
                Console.Write("첫번째 숫자를 입력하세요: ");
                input_x = Console.ReadLine();
                x = int.Parse(input_x);

                Console.Write("두번째 숫자를 입력하세요: ");
                input_y = Console.ReadLine();
                y = int.Parse(input_y);


                    Console.Write("계산방법을 선택하시요: (1)덧셈 (2)뺄셈 (3)곱셈 (4)나눗셈 => ");
                     Calculate_Method = Console.ReadLine();
                     Calculate_Method_Number = int.Parse(Calculate_Method);


                switch (Calculate_Method_Number)
                {
                    case 1:
                        Result = Plus(x, y);
                        Console.Write("결과값: {0}\n\n", Result);
                        break;

                    case 2:
                        Result = Minus(x, y);
                        Console.Write("결과값: {0}\n\n", Result);
                        break;

                    case 3:
                        Result = Multiplex(x, y);
                        Console.Write("결과값: {0}\n\n", Result);
                        break;

                    case 4:
                        Divide(x, y, out Result, out Remain_Result);
                        Console.Write("결과값/나머지값: {0}/{1}\n\n", Result, Remain_Result);
                        break;

                    default:
                        Console.WriteLine("\n\n잘못된 번호입니다.");
                        break;
                }
                Console.Write("계속 계산 하시겠습니까? Y/N => ");
                Power_Method = Console.ReadLine();

                if (Power_Method == "Y")
                    break;
            }
        }
    }
}