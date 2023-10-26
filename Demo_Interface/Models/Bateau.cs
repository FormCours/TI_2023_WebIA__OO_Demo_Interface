using Demo_Interface.Enums;
using Demo_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Models
{
    internal class Bateau : Vehicule, IBateau
    {
        public string Marque { get; set; } = null!;

        public ModePropulsionBateauEnum ModePropulsion { get; set; }

        public void Naviguer()
        {
            Console.WriteLine($"Le bateau {Marque} {Modele} navigue.");
        }

        public void Tourner()
        {
            Console.WriteLine($"Le bateau {Marque} {Modele} tourne.");
        }
    }
}
