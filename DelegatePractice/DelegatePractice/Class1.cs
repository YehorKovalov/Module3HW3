using System;

namespace DelegatePractice
{
    public class Class1
    {
        public Action<bool> ShowHandler { get; set; }
        public static double Pow(double x, double y) => Math.Pow(x, y);
    }
}
