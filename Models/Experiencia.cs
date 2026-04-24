using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuCurriculo.Models
{
    public class Experiencia
    {
        public string Empresa { get; set; } 
        public string Cargo { get; set; }
        public string Início { get; set; } = "Atual";
        public string Fim { get; set; }
        public string Descricao { get; set; }
    }
}