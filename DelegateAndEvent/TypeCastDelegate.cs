using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    // DELEGATE MODIFER/DELEGATE/RETURN TYPE/NAME OF DELEGATE(PARAMETHER)
    public delegate void Calculation(int a, int b);
    public class TypeCastDelegate
    {
        public void Add1(int a, int b)
        {
            Console.WriteLine("sum is {0}", a + b);
        }
        public void Sub1(int a, int b)
        {
            Console.WriteLine("sub is {0}", a - b);
        }

    }
}
