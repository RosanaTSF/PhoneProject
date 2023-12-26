using System;
using DesafioPOO.Models;

namespace PhonePooProject.Models
{
    public class Flip : Smartphone
    {
        public Flip(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) //Construtor da classe Flip que repassa os parâmetros para o construtor da classe base Smartphone.
        {
        }
        public override void InstalarAplicativo(string nomeApp) //Declaração do método InstalarAplicativo, sobrescrito da classe base.
        {
            Console.WriteLine($"Instalando {nomeApp} no Flip.");
        }
    }
}
