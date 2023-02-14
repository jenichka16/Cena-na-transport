using MVCTransport.Model;
using MVCTransport.Views;

namespace MVCTransport
{
    internal class TransportActionController
    {
        private Display display;
        private Transport transport;
        

          public TransportActionController()
        {
            display = new Display();
            transport = new Transport(display.Km, display.Time);
            display.TotalPrice = transport.CalculatePrice();
            display.ShowPrice();
        }
    }
}
