using System;

namespace Revisao.Sub.Primeiro.Trimestre
{
    /// <summary>
    /// .NET Framework single plataform (apenas windows)
    /// .NET Core mult plataform (windows, linux, mac, etc...)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tipo de valor

            int inteiro1 = 0;
            int inteiro2 = inteiro1;
            inteiro1 = 1;

            Console.WriteLine($"inteiro1={inteiro1}");
            Console.WriteLine($"inteiro2={inteiro2}");

            #endregion tipo de valor

            #region tipo de referencia

            var carro1 = new Carro("KIA");
            var carro2 = carro1;

            carro1.Marca = "JEEP";

            Console.WriteLine($"carro1:{carro1.Marca}");
            Console.WriteLine($"carro2:{carro2.Marca}");

            #endregion tipo de referencia

            #region Construtores

            var carro3 = new JeepRenegate();

            #endregion Construtores

            Console.ReadLine();
        }
    }
}
