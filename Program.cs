using System.ComponentModel;

namespace WinFormsApp1
{
    internal static class Program
    {
        public static double numberA = 1;
        public static double numberB = 1;
        public static double numberC = 0;
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new TriangleUI());

        }

        public static double Pythagorean()
        {
            numberC = Math.Sqrt(numberA * numberA + numberB * numberB);
            return numberC;
        }

    }
}