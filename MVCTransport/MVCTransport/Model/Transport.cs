using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTransport.Model
{
    public class Transport
    {
        private int km;
        private string time;

        public Transport(int km, string time)
        {
            this.Km = km;
            this.Time = time;
        }

        public int Km { get; set; }
        public string Time { get; set; }

        public double CalculatePrice()
        {
            double taksa = 0;
            double tarifa = 0;
            if (this.km < 20)
            {
                taksa = 0.70;
                if (this.Time == "day")
                {
                    tarifa = 0.79;
                }
                else
                {
                    tarifa = 0.9;
                }
            }
            else if (this.Km < 100)
            {
                {
                    tarifa = 0.09;
                }
            }
            else
            {
                tarifa = 0.06;
            }
            return taksa + tarifa * this.Km;
        }
    }
}

