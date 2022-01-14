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
    public class Invia
    {
        private string nomeUtente;
        string ip;
        public Invia()
        {
            this.nomeUtente = "";
        }
        public void setNomeUtente(string nomeUtente)
        {
            this.nomeUtente = nomeUtente;
        }

        public bool inviaInvito(string ip)
        {

            UdpClient client = new UdpClient();
            byte[] data = Encoding.ASCII.GetBytes("a;" + nomeUtente + ";" + "666" + ";");
            bool controllo = false;
            this.ip = ip;
            try
            {
                client.Send(data, data.Length, ip, 12345);
                IPEndPoint riceveEP = new IPEndPoint(IPAddress.Any, 12345);
                byte[] dataReceived = client.Receive(ref riceveEP);
                String risposta = Encoding.ASCII.GetString(dataReceived);

                string[] str = risposta.Split(';');
                string yN = str[0];
                string nU = "";

                if (yN == "y")
                {
                    nU = str[1];
                    paginaDiGioco finestra = new paginaDiGioco();
                    MainWindow finestra2 = new MainWindow();
                    finestra.Show();
                    finestra2.Close();
                    finestra.modalitaAvvioPartita("invitato");
                    MessageBox.Show("Inserisci le navi, una volta pronto premi 'GIOCA'", "Prepara il tuo campo!");
                }
                else if (yN == "n")
                {
                    MessageBox.Show("L'utente ha rifiutato il tuo invito", "Negative");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Rilevato il seguente errore: " + e.Message, "Errore di comunicazione");
                controllo = true;
            }
            return controllo;
        }
        public void inviaCoordinate(string lett, string num)
        {
            UdpClient client = new UdpClient();
            byte[] data = Encoding.ASCII.GetBytes(lett + ";" + num + ";");
            client.Send(data, data.Length, ip, 12345);
            IPEndPoint riceveEP = new IPEndPoint(IPAddress.Any, 12345);
            byte[] dataReceived = client.Receive(ref riceveEP);
        }
    }
}
