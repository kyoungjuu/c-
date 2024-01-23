using System;

class ConsoleApp1
{
    static void Main(string[] args)
    {
        string[] namearr =;
        int[] agearr;
        float[] floatarr;
        const int asdf = 10;

        asdf = 56;



        Console.WriteLine("이름을 입력하세요:");
        string name = Console.ReadLine();
        namearr[0] = name;
        Console.WriteLine("나이를입력하세요:");
        string age_str = Console.ReadLine();
        int age = int.Parse(age_str);
        Console.WriteLine("키를 입력하세요:");
        string key_str = Console.ReadLine();
        float key = float.Parse(key_str);

        Console.WriteLine("이름:" + name. + " 나이:" + ++age + " 키:" + key.ToString());
    }
}


