using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuCurriculo.Models
{
    public class Experiencia
    {
        public String? Empresa { get; set; } 
        public String? Cargo { get; set; }
        public String? Inicio { get; set; } = "Atual";
        public String? Fim { get; set; }
        public String? Descricao { get; set; }
    }
}