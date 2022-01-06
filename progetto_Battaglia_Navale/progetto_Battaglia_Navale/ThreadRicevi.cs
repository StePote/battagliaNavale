using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace progetto_Battaglia_Navale
{
    class ThreadRicevi
    {
        public void ricevi()
        {
            UdpClient client = new UdpClient(666);

            IPEndPoint riceveEP = new IPEndPoint(IPAddress.Any, 666);
            byte[] dataReceived = client.Receive(ref riceveEP);
            String risposta = Encoding.ASCII.GetString(dataReceived);
            MessageBox.Show(risposta);
        }
    }
}
