using basics.Math;

namespace basics
{
    class Program
    {

        static void Main(string[] args)
        {
            // Intro.TrashPanda();
            // Types.TypeConversion();
            // Operators.Overview();
            // int result = Calculator.Add(2, 3); // <~~ static, no object creation
            
            Calculator TI82 = new Calculator();
            TI82.Add(-2, 8);
            TI82.ReadDisplay();

            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Connor";
            john.Introduce();

            RgbColor balls = new RgbColor();
            balls.Red = 200;
            balls.Green = 100;
            balls.Blue = 35;
        }

    }
}
