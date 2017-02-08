using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh05
    {
        class Radio
        {
            public bool PowerOn { get; set; }
            public int Volume { get; set; }
            public double Freq { get; set; }

            public void Power(bool poweron)
            {
                PowerOn = poweron;
            }

            public void SetFreq(double freq)
            {
                if (freq <= 26000 && freq >= 2000)
                {
                    Freq = freq;
                }
            }

            public void SetVolume(int volume)
            {
                if (volume >= 1 && volume <= 9)
                {
                    Volume = volume;
                }
            }

            public override string ToString()
            {
                return "Power: " + PowerOn + "\nVolume: " + Volume + "\nFrequency: " + Freq;
            }
        }
    }
