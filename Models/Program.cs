using System; // Lógica: Importa o namespace System para utilizar funcionalidades básicas do C#.
using DesafioPOO.Models; // Lógica: Importa o namespace DesafioPOO.Models para utilizar a classe base Smartphone.
using PhonePooProject.Models; // Lógica: Importa o namespace PhonePooProject.Models para utilizar as classes Flip e Iphone.

namespace PhonePooProject // Lógica: Define o namespace para a classe Program no contexto do projeto PhonePooProject.
{
    class Program 
    {
        static void Main() // Lógica: Declaração do método Main, ponto de entrada do programa.
        {
            Flip f = new Flip("123456789", "ModelFlip", "IMEIFlip", 512); // Lógica: Cria uma instância da classe Flip chamada f com valores específicos passados como parâmetros para o construtor.
            f.InstalarAplicativo("AppFlip"); // Saída: Mensagem formatada na console. Lógica: Chama o método InstalarAplicativo da instância f (objeto da classe Flip), indicando que um aplicativo está sendo instalado no Flip.
            Iphone i = new Iphone("111222333", "ModelIphone", "IMEIIphone", 1024); // Lógica: Cria uma instância da classe Iphone chamada i com valores específicos passados como parâmetros para o construtor.
            i.InstalarAplicativo("AppIphone"); // Saída: Mensagem formatada na console. Lógica: Chama o método InstalarAplicativo da instância i (objeto da classe Iphone), indicando que um aplicativo está sendo instalado no iPhone.

            Console.ReadLine(); // Lógica: Aguarda a entrada do usuário antes de encerrar a execução do programa.    
        }
    }
}
