using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator_Ver1
{
    class Program
    {


        static void Main(string[] args)
        {

            string caculator_power_method;


            Console.WriteLine("Caculator 0.1 by SCOUTLEE\n\n\n\n\n\n");

            //계산기반복을 시작할 것인지 안할 것인지 구분
            Console.WriteLine("계산기를 시작하시겠습니까? 시작은 (y) 종료하려면 아무키나 누르시요.");
            caculator_power_method = Console.ReadLine();


            //y를 눌렀을 경우 계산기 시작`
            while (caculator_power_method == "y") {

                //변수선언
                int a, b, c, d, e, f, g;
                string input_a, input_b, input_c, input_d, input_e, input_f, input_g;
                string caculator_method;
                int caculator_method_number;
                int result;
                int remainder_result;

                //input_a라는 string변수에 값을 입력 받음
                Console.WriteLine("\n\n\n\n\n\nA값을 입력해주세요:");
                input_a = Console.ReadLine();
                a = int.Parse(input_a); // string 숫자를 int변수에 맞게 변환시켜줌

                //input_b라는 string변수에 값을 입력 받음
                Console.WriteLine("\n\nB값을 입력해주세요:");
                input_b = Console.ReadLine();
                b = int.Parse(input_b); // string 숫자를 int변수에 맞게 변환시켜줌

                //변환된 값들을 보여줌
                Console.WriteLine("\n\na값은 {0} 이고 b값은 {1} 입니다", a, b);

                //변수에 맞는 값을 넣고 반복실행
                Console.WriteLine("\n\n연산을 선택해주세요  (1)합연산 (2)차연산 (3)곱연산 (4)나눗연산");
                caculator_method = Console.ReadLine();
                caculator_method_number = int.Parse(caculator_method);

                //맞는 번호 넣을 때 까지 반복
                    while (caculator_method_number > 4) {

                        Console.WriteLine("\n\n잘못된 번호입니다.");
                        Console.WriteLine("연산을 선택해주세요  (1)합연산 (2)차연산 (3)곱연산 (4)나눗연산");
                        caculator_method = Console.ReadLine();
                        caculator_method_number = int.Parse(caculator_method);

                        if (caculator_method_number < 5)

                            break;

                    } 

                    //본격 계산
                    switch (caculator_method_number)
                    {

                        case 1:
                            result = a + b;
                            Console.WriteLine("\n\n결과값은 {0}입니다.", result);
                            break;

                        case 2:
                            result = a - b;
                            Console.WriteLine("\n\n결과값은 {0}입니다.", result);
                            break;

                        case 3:
                            result = a * b;
                            Console.WriteLine("\n\n결과값은 {0}입니다.", result);
                            break;

                        case 4:
                            result = a / b;
                            remainder_result = a % b;
                            Console.WriteLine("\n\n결과값은 {0}입니다. 나머지는 {1}입니다.", result, remainder_result);
                            break;
                    }

                //계산을 계속 할 것인지 어플리케이션을 종료할 것인지 변수를 입력
                Console.WriteLine("\n\n새로 계산 하시겠습니까? 계속하려면 (y) 종료하려면 아무키나 누르시요. ");
                caculator_power_method = Console.ReadLine();

                if (caculator_power_method == "y")
                    continue;

            }

            }
        }
    }
