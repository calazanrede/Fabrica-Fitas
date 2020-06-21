using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitas_Fabrica.Models
{
    public class Adesiva : Fita 
    {
        public string duplaFace { get; set; }
        public double aderencia { get; set; }

        public string tipo { get; set; }
    }
}
