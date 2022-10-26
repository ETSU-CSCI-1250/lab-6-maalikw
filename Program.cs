namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Homework 6";
            Console.ForegroundColor = ConsoleColor.Green;

            ShowCharacter("ETSU", 2);

            Console.WriteLine("-----------");

            Console.WriteLine(CalculateRetail(5.00f, 0.5f));

            Console.WriteLine("-----------");

            Console.WriteLine(Celsius(80.0));

            Console.WriteLine("-----------");




            Console.ReadKey();
        }
        #region Show Character
        static void ShowCharacter(string a, int b)
        {
            Console.WriteLine($"{a[b]}");
        }
        #endregion
        #region Retail Price
        static float CalculateRetail(float w, float m)
        {
            float retail = (w + (w * m));
            return retail;
        }
        #endregion
        #region Temperature Table
        static double Celsius(double f)
        {
            double c;
            c = 5 / 9 * (f - 32);
            for (int i = 80; i <= 100; i++)
            {
                Console.WriteLine($"{i}--C: {c}......F: {f}");
            }
            return c;
        }
        #endregion
    }
}