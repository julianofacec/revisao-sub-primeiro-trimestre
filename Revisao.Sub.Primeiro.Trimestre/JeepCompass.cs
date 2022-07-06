using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Sub.Primeiro.Trimestre
{
    internal struct JeepCompass
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        // não permite construtor vazio após definição de um
        // construtor que receba parametros
        //public JeepCompass()
        //{

        //}

        public JeepCompass(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
    }
}