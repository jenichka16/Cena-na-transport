using MVCTransport.Model;
using MVCTransport.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTransport.Controllers
{
    public class TransportController
    {
        private Display display;
        private Transport transport;

        public TransportController()
        {
            display = new Display();
            transport = new Transport(display.Km, display.Time);
            display.TotalPrice = transport.CalculatePrice();
            display.ShowPrice();
        }
    }
}
