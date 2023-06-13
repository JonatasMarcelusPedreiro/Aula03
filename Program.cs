using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // criar uma variável 
            string criador = "Jonatas";
            int idade = 18;
            float dinheiro = 20.50f ;

            float peso = 64.0f;
            float altura = 1.70f;
            float imc = peso / altura * (altura);
            Console.WriteLine($" Seu imc é {imc} ");
            int soma = 78 + 192;
            Console.WriteLine($" o resultado é {soma}");
            Console.WriteLine($" Meu nome é {criador} e eu tenho {idade} anos e na minha carteira tem {dinheiro} ");
            Console.WriteLine($" Na minha carteira tem {dinheiro} ");
            
          
            Console.WriteLine(" \n Aula 03 variáveis");
            Console.WriteLine(" \n Programa criado por " + criador);
            Console.WriteLine(" Eu sou o " + criador);
            Console.WriteLine(" Lembrando que quem fez foi o " + criador);   
            // Não esquecer o ; no final

            Console.Read();




        }
    }
}
