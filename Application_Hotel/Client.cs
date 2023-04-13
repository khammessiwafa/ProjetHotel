using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelClient
{
    internal class Client
    {


        private int numeroChambre;

        public int NumeroChambre
        {
            get; set;

        }

        private string nom;

        public string Nom
        {
            get; set;
        }

        private string prenom;

        public string Prenom
        {
            get; set;
        }

        private string courriel;

        public string Courriel
        {
            get; set;
        }
        private string carteCredit;

        public string CarteCredit
        {
            get; set;
        }

        public Client(string nom,
                       string prenom,

                       string courriel, string carteCredit, int numeroChambre)
        {
            NumeroChambre = numeroChambre;
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
            CarteCredit = carteCredit;


        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Numero de la chambre :" + NumeroChambre);
            stringBuilder.AppendLine("Nom : " + Nom + " " + Prenom);

            stringBuilder.AppendLine("Courriel : " + Courriel);
            stringBuilder.AppendLine("Numero de la carte de Crédit : " + CarteCredit);



            return stringBuilder.ToString();
        }


    }
}
