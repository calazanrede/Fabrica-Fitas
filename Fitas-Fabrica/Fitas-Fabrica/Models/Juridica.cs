using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitas_Fabrica.Models
{
    public class Juridica : Pessoa
    {
        public string cnpj { get; set; }
        public string razaoSocial { get; set; }
        public string cnae { get; set; }
        public bool multinacional { get; set; }
        public string tipoEmpresa { get; set; }
        public string responsavel { get; set; }
    }
}
