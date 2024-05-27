using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstraindoCelularPoo.Models
{
    public class Iphone(string numero, string modelo, string imei, int memoria) : Smartphone(numero, modelo, imei, memoria)
    {
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"*** Instalando Aplicativo Iphone **");
            Console.WriteLine($"   @ {nomeApp}\n");
        }
    }
}