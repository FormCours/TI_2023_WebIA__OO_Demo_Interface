using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface.Models
{
    public class Vehicule
    {
        public virtual string Modele { get; set; } = null!;
        public string? Immatriculation { get; set; }
    }
}
