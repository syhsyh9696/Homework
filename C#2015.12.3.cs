using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_33
{
    class Program
    {
        static IEnumerable<string> AddNumbers(IEnumerable<string> names)
        {
            Console.WriteLine("Starting AddNumbers");
            int i = 0;
            foreach (string currentName in names)
            {
                Console.WriteLine("In AddNumbers: " + currentName);
                yield return string.Format("{0}: {1}", i, currentName);
                i += 1;
            }
            Console.WriteLine("Leaving AddNumbers");
        }
        static void Main(string[] args)
        {
            string[] eventNames =
            {
                
                "Swing Dancing at the South Bank",
                "Saturday Night Swing",
                "Formula 1 German Grand Prix",
                "Swing Dance Picnic",
                "Stompin' at the 100 Club"
            };
            Console.WriteLine("Calling AddNumbers");
            IEnumerable<string> numberedNames = AddNumbers(eventNames);
            Console.WriteLine("Starting main loop");
            foreach (string numberedName in numberedNames)
            {
                Console.WriteLine("In main loop: " + numberedName);
            }
            Console.WriteLine("Leaving main loop");
            Console.ReadKey();
        }        
    }
} 
