//C#의 분기분에 대해 알아보자!
// using System;

// namespace TestFile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("put the number on it : ");
//             string input = Console.ReadLine();
//             int number = Int32.Parse(input);

//             if(number < 0)
//             {
//                 Console.WriteLine("음수");
//             }
//             else if(number > 0)
//             {
//                 Console.WriteLine("양수");
//             }
//             else
//             {
//                 Console.WriteLine("0");
//             }

//             if(number % 2 == 0)
//             {
//                 Console.WriteLine("짝수");
//             }
//             else
//             {
//                 Console.WriteLine("홀수");
//             }
//         }
//     }
// }

//C#의 분기분에 대해 알아보자! _ if 조건 중첩

// using System;

// namespace TestFile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("put the number on it : ");
//             string input = Console.ReadLine();
//             int number = Convert.ToInt32(input);

//             if(number > 0)
//             {
//                 if(number % 2 == 0)
//                 {
//                     Console.WriteLine("짝수");
//                 }
//                 else
//                 {
//                     Console.WriteLine("홀수");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("0보다 작거나 같은 수");
//             }
//         }
//     }
// }

// Switch case 문 _ 반복 분기문

// using System;

// namespace TestFile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("날짜를 입력해주세요 : ");
//             string Day = Console.ReadLine();

//             switch(Day)
//             {
//                 case "일" :
//                     Console.WriteLine("Sunday");
//                     break;
//                 case "월" :
//                     Console.WriteLine("Monday");
//                     break;
//                 case "화":
//                     Console.WriteLine("Tuesday");
//                     break;
//                 case "수":
//                     Console.WriteLine("Wednesday");
//                     break;
//                 case "목":
//                     Console.WriteLine("Thursday");
//                     break;
//                 case "금" :
//                     Console.WriteLine("Friday");
//                     break;
//                 case "토" :
//                     Console.WriteLine("Saturday");
//                     break;
//             }
//         }
//     }
// }


// Switch문_ 식별자 문자

// using System;

// namespace TestFile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             object obj = null;
//             Console.WriteLine("put the any number you want(But, do not use the odd number!) : ");
//             string s = Console.ReadLine();
//             if(int.TryParse(s, out int out_i))
//                 obj = out_i;
//             else if(float.TryParse(s, out float out_f))
//                 obj = out_f;
//             else
//                 obj = s;

//             switch (obj)
//             {
//                 case int i:
//                     Console.WriteLine($"{i} is a int format.");
//                     break;
//                 case float f:
//                     Console.WriteLine($"{f} is a float format");
//                     break;
//                 default :
//                 {
//                     Console.Write($"{obj}은(는) 모르는 형식입니다.");
//                     break;
//                 }
//             }
//         }
//     }
// }

//  Switch ~ Case 문에서 'When' 절을 활용한다면 어떻게 될까?

// using System;

// namespace TestFile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             object obj = null;
//             string s = Console.ReadLine();

//             if(int.TryParse(s, out int out_i))
//                 obj = out_i;
//             else if(float.TryParse(s, out float out_f))
//                 obj = out_f;
//             else
//                 obj = s;

//             switch(obj)
//             {
//                 case int i when i > 0 :
//                     Console.Write($"{i}는 정수형 형식입니다.");
//                     break;
//                 case float f :
//                     Console.Write($"{f}은(는) 실수형 형식입니다.");
//                     break;
//                 default :
//                     Console.Write($"{obj}은(는) 모르는 형식입니다!");
//                     break;
//             }
//         }
//     }
// }

// Switch 문_ 학점 계산기

// using System;

// namespace TestFile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("점수를 입력하세요! ");
//             int score = Convert.ToInt32(Console.ReadLine());

//             Console.Write("재수강 인가요(Y/N) : ");
//             string Line = Console.ReadLine();
//             bool repeated = Line == "y"?true:false;

//             string grade = (int)(Math.Truncate(score/10.0) * 10) switch
//             {
//                 90 when repeated == true => "B+",
//                 90 => "A",
//                 80 => "B",
//                 70 => "C",
//                 60 => "D",
//                 _ => "F"
//             };
//             Console.WriteLine($"학점 :{grade}");
//         }
//     }
// }

//While문 _ 분기문

// using System;

// namespace TestFile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i = 10;
//             while(i > 0)
//             {
//                 Console.WriteLine($"i : {i--}");
//             }
//         }
//     }
// }

 //do ~ while

//While문 _ 분기문

// using System;

// namespace TestFile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i = 10;
//             do
//             {
//                 Console.WriteLine("a) i : {0}", i--);
//             }
//             while (i > 0);

//             do
//             {
//                 Console.WriteLine("b) i : {0}", i--);
//             }
//             while (i > 0);
//         }
//     }
// }

//for 문 활용법 

// using System;

// namespace TestFile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for(int i = 0; i < 5; i++)
//             {
//                 Console.WriteLine(i);
//             }
//         }
//     }
// }


// 별 찍기 예제 

// using System;

// namespace TestFile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for(int i = 0; i < 5; i++)
//             {
//                 for(int j = 5; j > i; j--)
//                 {
//                     Console.Write("*");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

// foreach 문은 배열이나 컬렉션을 취급하며, 컬렉션 안에 있는 수를 돌아가며서 출력해줌. 
// using System;

// namespace TestFile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {      
//             int[] arr = new int[]{0,1,2,3,4};
//             foreach(int a in arr)
//                 Console.WriteLine(a);
//         }

//     }
// }

// using System;

// namespace TestFile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i = 0;
//             do
//             {
//                 int j = 0;
//                 do
//                 {
//                     Console.Write("*");
//                     j++;  
//                 }
//                 while(j<=i);
//                 Console.WriteLine();
//                 i++;
//             }   
//             while(i < 5);
//         }
//     }
// }