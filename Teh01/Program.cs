using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh01
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();
            Console.WriteLine("Elevator is in now in floor: " + hissi.Floor);
            bool result;
            do
            {
                Console.Write("Give a new floor number (1-5): ");
                string line = Console.ReadLine();
                int number;
                result = int.TryParse(line, out number);
                hissi.Floor = number;
                Console.WriteLine("Elevator is now in floor: " + hissi.Floor);
            }
            while (result == true);

        }
    }
}
