// See https://aka.ms/new-console-template for more information

//class Hello
//{
//    static void Main()
//    {
//        System.Console.WriteLine("Hello, World");
//    }
//}

//using System;{
//    static void Main()
//    {
//        Console.WriteLine("Hello, World");
//    }
//}

//class Hello
//{
//    static void Main()
//    {
//        Hello hello = new Hello();
//    }
//}

//Console.Write("이름을 입력하세요: ");
//Console.Write("나이를 입력하세요: ");

//using System;

//namespace A005_string
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string a = "hello";
//            string b = "h";

//            b = b + "ello";
//            Console.WriteLine(a == b);
//            Console.WriteLine(" b =" + b);

//            int X = 10;
//            string c = b + '!' + "" + X;
//            Console.WriteLine("c =" + c);
//        }
//    }
//}

//using System;

//namespace A007_ConsoleWriteLine
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool b = true;
//            char c = 'A';
//            decimal d = 1.234m; // m은 deciaml 형의 접미사
//            double e = 0;
//            float f = 0;
//            int g = 0;
//            string s = "Hello";

//            Console.WriteLine(b);
//            Console.WriteLine(c);
//            Console.WriteLine(d);
//            Console.WriteLine(e);
//            Console.WriteLine(f);
//            Console.WriteLine(g);
//            Console.WriteLine(s);
//        }
//    }
//}

//using System;

//namespace A008_ConsoleWriteMulti
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("10이하의 소수 : {0},{1}, {2}, {3}", 2, 3, 5, 7);

//            string primes;
//            primes = String.Format("10이하의 소수 : {0},{1}, {2}, {3}", 2, 3, 5, 7);
//            Console.WriteLine(primes)
//        }
//    }
//}

//using System

//namespace A009_VariablesAndWrite
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int v1 = 100;
//            double v2 = 1.24;

//            Console.WriteLine(v1.ToString()+","+ v2.ToString());
//            Console.WriteLine("v1 ="+v1+"v2 = "+ v2);
//            Console.WriteLine($"v1={v1},v2 ={v2}");
//        }
//    }
//}


//using System

//    namespace A011_FormatSpecifier
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("{0:N2}", 123.456);
//        }
//    }
//}

//using System;
//using System.Runtime.InteropServices;

//namespace A012_FloatDoubleDecimal
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            float flt = 1F / 3;
//            double db1 = 1D / 3;
//            decimal dcm = 1M / 3;

//            Console.WriteLine("float :{0}|ndouble : {1}|ndecimal : {2}", flt, db1, dcm);
//        }
//    }
//}

