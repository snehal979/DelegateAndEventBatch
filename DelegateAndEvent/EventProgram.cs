using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    public class EventProgram
    {
        public delegate void EventHandler(string x);

        public class Operation
        {
            public event EventHandler xyz;
            public void Action(string a)
            {
                if (xyz != null)
                {
                    xyz(a);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("not resigerter");
                }
            }
        }
        static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }
        public static void Implementation()
        {
            Operation o = new Operation();
            o.Action("event calling");
            o.xyz += new EventHandler(CatchEvent);
            o.Action("Event Calling");
        }
    }
}
