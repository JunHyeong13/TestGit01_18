using System;

namespace SwapByValue
{
    class MainApp
    {
        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

// a 와 b 는 각각 다른 데이터 저장소를 가지고 있을 뿐. X,Y의 인자 값을 받았다고 한들, 값이 변환되거나 하지는 X -> '값에 의한 전달' 이라고 부름.  

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x : {x}, y : {y}");
            Swap(x,y);

            Console.WriteLine($"x : {x}, y : {y}");
        }
    }
}