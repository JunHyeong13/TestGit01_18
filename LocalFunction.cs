// using System;

// namespace LocalFunction
// {
//     class MainApp
//     {
//         static string ToLowerString(String input)
//         {
//             var arr = input.ToCharArray();
//             for(int i = 0; i < arr.Length; i++)
//             {
//                 arr[i] = ToLowerChar(i);
//             }
//             Char ToLowerChar(int i)
//             {
//                 if(arr[i] < 65 || arr[i] > 90)
//                 {
//                     return arr[i];
//                 }
//                 else
//                     return (char)(arr[i]+32);
//             }
//             return new string(arr);
//         }
//         static void Main(String[] args)
//         {
//             Console.WriteLine(ToLowerString("Hello"));
//             Console.WriteLine(ToLowerString("Good Morning"));
//             Console.WriteLine(ToLowerString("This is C#"));
//         }
//     }
// }