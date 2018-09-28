namespace basics.Math
{
    public class Calculator
    {
        public int display { get; set; }
        public void ReadDisplay()
        {
            System.Console.WriteLine(this.display);
        }
        public void Add(int a, int b)
        {
            this.display = a + b;
        }
    }
}
