// using System;

// namespace FunctionTest
// {
//     class MainApp
//     {
//         static double Square(double arg)
//         {
//             return arg * arg;
//         }
//         static void Main(string[] args)
//         {
//            #nullable disable
//             Console.Write("수를 입력하세요 : ");
//             string number = Console.ReadLine();
//             double arg = Convert.ToDouble(number); //34.2

//             Console.WriteLine("결과 : {0}", Square(arg));
//         }
//     }
// }

using System;

namespace Ex6_2
{
    class MainApp
    {
        public static void Main()
        {
            double mean = 0; // 초기화
            Mean(1, 2, 3, 4, 5, ref mean); // 로컬 함수 호출
            Console.WriteLine("평균 : {0}", mean); // a + b + c + d + e / 5 한 값을 줘야 해.
        }
        public static void Mean( // 로컬 함수 선언
            double a, double b, double c,
            double d, double e, ref double mean
        )
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}