using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Sub.Primeiro.Trimestre
{
    internal class JeepRenegate : AbstractModelo, ICarro
    {
        public JeepRenegate() : base("JEEP","Renegate") { }

        public void Acelerar()
        {
            Console.WriteLine("Acelerou!");
        }

        public void Frear()
        {
            Console.WriteLine("Freiou!");
        }

        public override string ToString()
        {
            base.ToString();
            return $"Marca:{Marca} - Modelo:{Modelo}";
        }
    }
}