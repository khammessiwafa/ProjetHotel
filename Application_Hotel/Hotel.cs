using System;
using hotelClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    internal class Hotel


    {

        private string nom;

        public string Nom
        {
            get;
            set;
        }

        private List<Client> listeClient;


        public Hotel(string nom)
        {
            Nom = nom;
            listeClient = new List<Client>();
        }

        public void AddClient(Client client)
        {
            listeClient.Add(client);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Hotel: " + Nom);

            stringBuilder.AppendLine("----Liste des clients----");
            foreach (Client client in listeClient)
            {
                stringBuilder.AppendLine(client.ToString());
                stringBuilder.AppendLine("-------------------------");
            }
            return stringBuilder.ToString();
        }
    }
}
