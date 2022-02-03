// using System;

// namespace Refreturn
// {
//     class Product
//     {
//         private int price = 100;

//         public ref int GetPrice()
//         {
//             return ref price; // 100
//         }
//         public void PrintPrice()
//         {
//             Console.WriteLine($"Price : {price}");
//         }
//     }

//     class MainApp
//     {
//         static void Main(string[]args)
//         {
//             Product carrot = new Product();
//             ref int ref_local_price = ref carrot.GetPrice(); // carrot에 GetPrice 안에 있는 return 값을 가져옴.
//             int normal_local_price = carrot.GetPrice();


//             carrot.PrintPrice(); // 100
//             Console.WriteLine($"Ref Local Price : {ref_local_price}");
//             Console.WriteLine($"Normal Local Price : {normal_local_price}");

//             ref_local_price = 200; // 200으로 지역 변수 값 초기화

//             carrot.PrintPrice(); // 200
//             Console.WriteLine($"Ref Local Price : {ref_local_price}"); 
//             Console.WriteLine($"Normal Local Price : {normal_local_price}");
//         }
//     }
// }