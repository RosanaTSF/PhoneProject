using System;
using DesafioPOO.Models;

namespace PhonePooProject.Models
{
    public class Flip : Smartphone
    {
        public Flip(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Flip.");
        }
    }
}
