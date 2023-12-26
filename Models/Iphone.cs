namespace DesafioPOO.Models
{
    public class Iphone : Smartphone //Declaração da classe Iphone que herda da classe Smartphone.
    {
        
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) //Construtor da classe Iphone que repassa os parâmetros para o construtor da classe base Smartphone.
        {
        }
        public override void InstalarAplicativo(string nomeApp) //Declaração do método InstalarAplicativo, sobrescrito da classe base.
        { 
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
        }
    }
}
