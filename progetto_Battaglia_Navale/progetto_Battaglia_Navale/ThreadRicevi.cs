using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string[] str = risposta.Split(';');
            string apertura = str[0];
            string nomeUtente = str[1];
            
            string message = "L'utente "+ nomeUtente +" vorrebbe gicare con te";
            string caption = "Invito ad una partita";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                byte[] data = Encoding.ASCII.GetBytes("y;utente");
                client.Send(data, data.Length, "localhost", 666);
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                byte[] data = Encoding.ASCII.GetBytes("n;");
                client.Send(data, data.Length, "localhost", 666);
            }

        }
    }
}
