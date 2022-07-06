using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Sub.Primeiro.Trimestre
{
    internal abstract class AbstractModelo : AbstractMarca
    {
        public string Modelo { get; set; }

        protected AbstractModelo(string marca, string modelo)
            : base(marca)
        {
            Modelo = modelo;
        }
    }
}
