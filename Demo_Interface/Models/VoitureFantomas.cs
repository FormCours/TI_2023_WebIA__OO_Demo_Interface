using Demo_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Models
{
    public class VoitureFantomas : Voiture, IVoiture, IAvion
    {
        public override string Marque
        {
            get { return "Citroën"; }
            set { throw new Exception("Non"); }
        }

        public override string Modele
        {
            get { return "DS"; }
            set { throw new Exception("Non"); }
        }

        public string Couleur { get; set; }

        public void Atterrir()
        {
            Console.WriteLine($"La {Marque} {Modele} atterri.");
        }

        public void Decoller()
        {
            Console.WriteLine($"La {Marque} {Modele} decolle.");
        }

        void IAvion.Tourner()
        {
            Console.WriteLine($"La {Marque} {Modele} plane.");
        }
        void IVoiture.Tourner()
        {
            Console.WriteLine($"La voiture de fantomas lache un fumigene.");
            Tourner();
        }
    }
}
