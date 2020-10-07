using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace IntroToCSharp
{
    class HelloCSharp
    {
        static void Main()
        {
            int current_run = 0;
            int max_runs = 100;
            int n = 2;

            while (current_run <= max_runs)
            {
                Console.WriteLine(n);
                current_run = current_run + 1;
                if (Math.Sign(n) != -1 ) // checking if the current value is odd
                {
                    n = n + 1;
                }
                else
                {
                    n = n * -1; // converting the value to be positive
                    n = n + 1; 
                }
               
               if(n%2 != 0 ) // checking if the new value is odd
                {
                    n = n * -1; // if it's odd, add a minus sign.
                }
            }
        }
    }
}