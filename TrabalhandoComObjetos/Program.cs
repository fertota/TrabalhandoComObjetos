using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trabalha com objetos do tipo pessoa
            //Inserindo dados da 1ª pessoa
            String entrada = "";
            Pessoa pessoa1;
            pessoa1 = new Pessoa();
            Console.WriteLine("Efetua a leitura dos dados de três pessoas.");
            Console.WriteLine("Dados da 1ª pessoa:");
            Console.Write("Informe o seu nome: ");
            entrada = Console.ReadLine();
            pessoa1.nome = entrada;
            Console.Write("Informe sua altura: ");
            entrada = Console.ReadLine();
            pessoa1.altura = Convert.ToDouble(entrada);
            pessoa1.faleSobreVoce();
            Console.WriteLine("\n"); // Comando utilizado para pular 1 linha
            
            //Inserindo dados da 2ª pessoa
            Pessoa pessoa2;
            pessoa2 = new Pessoa();
            Console.WriteLine("Dados da 2ª pessoa:");
            Console.Write("Informe o seu nome: ");
            entrada = Console.ReadLine();
            pessoa2.nome = entrada;
            Console.Write("Informe sua altura: ");
            entrada = Console.ReadLine();
            pessoa2.altura = Convert.ToDouble(entrada);
            pessoa2.faleSobreVoce();
            Console.WriteLine("\n"); // Comando utilizado para pular 1 linha
            
            //Inserindo dados da 3ª pessoa
            Pessoa pessoa3;
            pessoa3 = new Pessoa();
            Console.WriteLine("Dados da 3ª pessoa:");
            Console.Write("Informe o seu nome:");
            entrada = Console.ReadLine();
            pessoa3.nome = entrada;
            Console.Write("Informe sua altura:");
            entrada = Console.ReadLine();
            pessoa3.altura = Convert.ToDouble(entrada);
            pessoa3.faleSobreVoce();
            Console.WriteLine("\n");
            Console.WriteLine("Sejam Bem-Vindos: " + pessoa1.nome + ", " + pessoa2.nome + " e " + pessoa3.nome + "!!!");
            Console.ReadKey();
        }
    }
}
