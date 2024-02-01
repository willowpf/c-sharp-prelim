
using System;

namespace Hemburger { 





    public class Math
{
    public void Add(int nim1, int nim2)
    {
            Console.WriteLine("Addition=  " + (nim1 + nim2));
        }

    public void Sub(int nim1, int nim2)
    {
            Console.WriteLine("Subtraction=  " + (nim1 - nim2));
    }
    public void Mul(int nim1, int nim2)
    {
            Console.WriteLine("Multiplication=  " + (nim1 * nim2));
        }
    public void Div(int nim1, int nim2)
    {
            Console.WriteLine("Division=  " + (nim1 / nim2));
        }


}





    class Program
    {
        static void Main(string[] args)
        {
            Math meth = new Math();

        int nim1, nim2;

            Console.WriteLine("Enter Numero 1:");
            nim1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Numero 2");
            nim2 = int.Parse(Console.ReadLine());

            meth.Add(nim1, nim2);
            meth.Sub(nim1, nim2);
            meth.Mul(nim1, nim2);
            meth.Div(nim1, nim2);



        }
    }
}