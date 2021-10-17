using System;

namespace DelegateDemo
{
    //Declaration of Delegats
    public delegate void AddSumDelegate(int a, int b);
    public delegate void SubDelegate(int a, int b);
    public delegate void MulDelegate(int a, int b);
    class Program
    {
        //Creating Methods to Refereance of Delegats
        public void AddSum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Addition of " + a + " and " + b + " is: " + c);
        }
        public void SubNumber(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Substraction of " + b + " from " + a + " is: " + c);
        }
        public void MulNumber(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Multiplication of " + a + " and " + b + " is: " + c);
        }
        static void Main(string[] args)
        {
            //Creating Object of Class
            Program p = new Program();

            //Calling The Delegates  
            AddSumDelegate ad = new AddSumDelegate(p.AddSum);
            ad(50, 25);
            SubDelegate sd = new SubDelegate(p.SubNumber);
            sd.Invoke(50, 25);
            MulDelegate md = new MulDelegate(p.MulNumber);
            md(5, 2);
            
        }
    }
}
