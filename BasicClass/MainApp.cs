using System;

namespace BasicClass
{
    class Cat
    {
        #nullable disable
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Cat Kitty = new Cat(); // Null, 'new' 키워드는 Cat() 생성자를 호출해서 객체 생성. 
            Kitty.Color = "하얀색";
            Kitty.Name = "키티";
            Kitty.Meow();
            Console.WriteLine($"{Kitty.Name} : {Kitty.Color}");

            Cat nero = new Cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}