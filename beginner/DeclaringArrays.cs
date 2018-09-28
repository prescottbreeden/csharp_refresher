namespace basics
{
    public class DeclaringArrays    
    {
        int[] numbers = new int[3];

        public void PrintMe()
        {
            foreach(int num in this.numbers)
            {
                System.Console.WriteLine(num);
            }
        }

        public void SetEachValue()
        {
            this.numbers[0] = 1;
            this.numbers[1] = 2;
            this.numbers[2] = 3;
        }

        public void SetOnInit()
        {
            this.numbers = new int[3] { 1, 2, 3 };
        }
    }

}