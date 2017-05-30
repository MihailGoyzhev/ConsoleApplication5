using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Money
{

    public int currency;
    public decimal Amount { get; set; }

    public static Money operator ++ (Money f)
    {
        f.currency++;

        return f;
    }
   
}


namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            Money m = new Money();
            m.currency = 100;

            m++;

            Console.WriteLine(m.currency);
            
        }
    }
}
