using System;

namespace basics
{
    public class Intro
    {
        private const float V = 20.95f;
        public static void TrashPanda()
        {
            byte num= 2;
            int count = 10;
            float totalPrice = V;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = false;
            var dingle = true;

            Console.WriteLine(num);
            System.Console.WriteLine(count);
            System.Console.WriteLine(totalPrice);
            System.Console.WriteLine(character);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(isWorking);
            System.Console.WriteLine(dingle);

            System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            // variable: a name given to a storage location in memory
            // constant: an immutable value

            const float Pi = 3.14f;
            System.Console.WriteLine(Pi);

        }
    }
}
