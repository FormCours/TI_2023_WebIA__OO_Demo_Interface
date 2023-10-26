using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Interfaces
{
    public interface IVoiture
    {
        public string Marque { get; }
        public string Modele { get; }
        public int NbPorte { get; }
        public int NbRoue { get; }


        public void Rouler();
        public void Tourner();
    }
}
