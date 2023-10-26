using Demo_Interface.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Interfaces
{
    public interface IBateau
    {
        public string Marque { get; }
        public string Modele { get; }
        public ModePropulsionBateauEnum ModePropulsion { get; }

        void Naviguer();
        void Tourner();
    }
}
