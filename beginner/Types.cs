using System;

namespace basics
{
    class Types
    {
        public static void Basics()
        {
            // ===============
            // Primitive Types
            // ===============

            // byte
            // short
            // int
            // float
            // double
            // decimal
            // char
            // bool

            float number = 1.2f;
            decimal constant = 1.2m;

            System.Console.WriteLine(number);
            System.Console.WriteLine(constant);

            // ===================
            // Non-Primitive Types
            // ===================

            // string
            // array
            // enum
            // class


            // =====
            // Scope
            // =====
            {
                byte a = 1;
                {
                    byte b = 2;
                    {
                        byte c = 3;
                        Console.WriteLine(c);
                    }
                    Console.WriteLine(b);
                }
                Console.WriteLine(a);
            }

            // type conversion
            byte balls = 1;
            int i = balls;
            int j = 2;
            byte castRequired = (byte)j;
            float f = 1.0f;
            int k = (int)f;

            // byte is smaller than int so there is no data loss for conversion
            // when data loss will occur you have to use casting to tell compiler 
            // that potential data loss is acceptable

            // Convert
            // ToByte()
            // ToInt16()
            // ToInt32()
            // ToInt64()

        }
        public static void TypeConversion()
        {
            int a = 1000;
            byte b = (byte)a;
            System.Console.WriteLine(a); // 1000
            System.Console.WriteLine(b); // 232 <~~ data loss

            var number = "1234";
            int i = Convert.ToInt32(number);
            System.Console.WriteLine(number);

            try
            {
                byte c = Convert.ToByte(number);
                System.Console.WriteLine(c);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Error, cannot convert variable to number");
            }

            try
            {
                string str = "true";
                bool balls = Convert.ToBoolean(str);
                System.Console.WriteLine(balls);

                int str2 = 0;
                bool balls2 = Convert.ToBoolean(str2);
                System.Console.WriteLine(balls2);

                int str3 = 1;
                bool balls3 = Convert.ToBoolean(str3);
                System.Console.WriteLine(balls3);

                string str4 = "True";
                bool balls4 = Convert.ToBoolean(str4);
                System.Console.WriteLine(balls4);

                string str5 = "Rubber Baby Buggy Bumpers";
                bool balls5 = Convert.ToBoolean(str5);
                System.Console.WriteLine(balls5);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Error, cannot convert variable to bool");
            }
        }

    }
}
