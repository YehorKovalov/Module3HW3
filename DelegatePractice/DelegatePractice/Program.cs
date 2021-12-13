using System;

namespace DelegatePractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var c1 = new Class1();
            var c2 = new Class2();
            c1.ShowHandler = Show;
            var calcRes = c2.Calc(Class1.Pow, 2, 4);
            var check1 = calcRes.Invoke(3);
            var check2 = calcRes.Invoke(4);
            c1.ShowHandler.Invoke(check1);
            c1.ShowHandler.Invoke(check2);
        }

        private static void Show(bool result)
        {
            Console.WriteLine($"Result: {result}");
        }
    }
}
