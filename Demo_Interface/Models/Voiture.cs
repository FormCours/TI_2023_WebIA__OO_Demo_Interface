using Demo_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Models
{
    public class Voiture : Vehicule, IVoiture
    {
        public virtual string Marque { get; set; } = null!;

        public int NbPorte { get; set; } 

        public int NbRoue { get; set; }

        public void Rouler()
        {
            Console.WriteLine($"La voiture {Marque} {Modele} roule.");
        }

        public void Tourner()
        {
            Console.WriteLine($"La voiture {Marque} {Modele} tourne.");
        }
    }
}
