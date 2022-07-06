using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Sub.Primeiro.Trimestre
{
    internal abstract class AbstractMarca
    {
        public string Marca { get; private set; }

        protected AbstractMarca(string marca)
        {
            // tratamento string nula, vazia ou espacos em branco
            //if (string.IsNullOrWhiteSpace(marca))
            //    throw new ArgumentNullException
            //    ("Marca não de ser nula.Verifique.");

            // tratamento de nulidade ambas estãocorretas
            //if (marca == null)
            //    throw new ArgumentNullException
            //    ("Marca não de ser nula.Verifique.");

            Marca = marca 
                ?? throw new ArgumentNullException
                ("Marca não de ser nula.Verifique.");
        }
    }
}