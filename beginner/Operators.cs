namespace basics
{
    class Operators
    {
        public static void Overview() {
            // Operators...
            // arithmetic, comparison, assignment, logical, bitwise
            
            /* 

            -- arithmetic operators --

                + , - , *, /
                ++
                --

            -- comparison operators --

                ==
                !=
                >
                >=
                <
                <=

            -- assignment operators --

                =
                +=
                -=
                *=
                /=
            
            -- logical operators --

                &&  - and
                ||  - or
                !   - not
            
            -- bitwise operators --

                &  - and
                |  - or

             */
            int num = 1;
            int num2 = num++;
            System.Console.WriteLine(num);
            System.Console.WriteLine(num2);

            int n = 1;
            int n2 = ++n;
            System.Console.WriteLine(n);
            System.Console.WriteLine(n2);

            var a = 10;
            var b = 3;
            System.Console.WriteLine(a / b);                // 3
            System.Console.WriteLine((float)a / (float)b);  // 3.3333

            var c = 1;
            var d = 2;
            var e = 3;
            System.Console.WriteLine(c + d * e); // order of operations are obeyed
            System.Console.WriteLine((c + d) * e); 

            System.Console.WriteLine(c == d);
            System.Console.WriteLine(c != d);
            System.Console.WriteLine(!(c != d));  // !(True) = False 

            System.Console.WriteLine(b > c && c > e);
            System.Console.WriteLine(b > c || c > e);
        }
    }
}
