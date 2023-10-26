using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Interfaces
{
    public interface IAvion
    {
        public string Marque { get; }
        public string Modele { get; }
        public string Couleur { get; }

        void Decoller();
        void Atterrir();
        void Tourner();
    }
}
