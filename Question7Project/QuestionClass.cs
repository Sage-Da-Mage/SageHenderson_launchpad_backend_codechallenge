using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7Project
{
    class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jefferey",
            "John"
        };

        public static void IterateThroughNamesList()
        {
            // Setup a variable for iteration without for/foreach
            int iterationVar = 0;

            // Begin the iteration process
            do
            {
                Console.WriteLine(NamesList.ElementAt(iterationVar));
                iterationVar++;
            } while (NamesList.Count > iterationVar);

            Console.WriteLine("Lookit Me! I did the thing, I iterated through NamesList without a 'for' or 'foreach' loop");

            return;
        }

    }
}
