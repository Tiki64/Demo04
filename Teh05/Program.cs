using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh05
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Radio radio = new Radio();
                radio.Power(true);
                radio.SetFreq(2000.8);
                radio.SetVolume(5);
                Console.WriteLine(radio.ToString());
            }
        }
    }
}
