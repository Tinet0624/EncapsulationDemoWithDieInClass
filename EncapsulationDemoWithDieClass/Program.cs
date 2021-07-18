using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemoWithDieClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Die[] dice = new Die[5];

            // rolls 5 seperate dice
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
                Console.WriteLine(dice[i].Value);
            }

            Console.ReadKey();
        }
    }
}
