using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Message mensagem;
            mensagem = new Message();
            mensagem.TextMessage = "Olá, Mundo!";
            mensagem.ShowMessage();

            
            Console.ReadLine();
        }
    }
}
