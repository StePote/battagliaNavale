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
    public class ThreadInvia
    {
        public void inviaInvito() {

            UdpClient client = new UdpClient();
            byte[] data = Encoding.ASCII.GetBytes("a;utente");
            client.Send(data, data.Length, "localhost", 666);

            IPEndPoint riceveEP = new IPEndPoint(IPAddress.Any, 666);
            byte[] dataReceived = client.Receive(ref riceveEP);
            String risposta = Encoding.ASCII.GetString(dataReceived);

            string[] str = risposta.Split(';');
            string yN = str[0];
            string nomeUtente = "";

            if (yN == "y")
            {
                nomeUtente = str[1];
                paginaDiGioco finestra = new paginaDiGioco();
                MainWindow finestra2 = new MainWindow();
                finestra.Show();
                finestra2.Close();
                MessageBox.Show("Inserisci le navi, una volta pronto premi 'GIOCA'", "Prepara il tuo campo!");
            }
            else if (yN == "n")
            {
                MessageBox.Show("L'utente ha rifiutato il tuo invito", "Negative");
            }
        }
    }
}
