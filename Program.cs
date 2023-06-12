using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        void Atividade01()
        {
            double numero;
            Console.Write("Insira um numero: ");
            numero = double.Parse(Console.ReadLine());

            if (numero > 10)
            {
                numero = numero * 0.1;
            }
            Console.WriteLine(numero);

            Console.WriteLine("Fim");
            Console.ReadKey();
        }
        void Atividade02()
        {
            int numero;
            Console.Write("Insira um numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 100)
            {
                numero = numero + 150;
            }

            Console.WriteLine($"Você digitou: {numero}");
            Console.WriteLine("Fim");
            Console.ReadKey();
        }
        void Atividade03parte1()
        {
            string nome;
            double media;
            Console.Write("Insira o nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write("Insira a média final do aluno: ");
            media = double.Parse(Console.ReadLine());

            Console.Write($"O(a) aluno(a) {nome} foi ");

            if (media >= 6.0)
            {
                Console.WriteLine("APROVADO :)");
            }
            else
            {
                Console.WriteLine("REPROVADO :(");
            }

            Console.WriteLine("Fim");

            Console.ReadKey();
        }
        void Atividade03parte2()
        {
            string nome;
            double nota1;
            double nota2;
            double media;

            Console.Write("Insira o nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write("Insira a primeira nota: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.Write("Insira a segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());

            media = ((nota1 + nota2) / 2);

            Console.Write($"O(a) aluno(a) {nome} teve ");

            if (media > 6.0)
            {
                Console.WriteLine("Média superior à média mínima (6,0)");
            }
            else if (media == 6)
            {
                Console.WriteLine("Média igual à média mínima(6,0)");
            }
            else
            {
                Console.WriteLine("Média inferior à média mínima (6,0)");
            }

            Console.WriteLine("Fim");

            Console.ReadKey();
        }
        void Atividade04()
        {
            double nota1;
            double nota2;
            double nota3;

            double maior;

            Console.WriteLine("Insira a primeira nota do aluno: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota do aluno: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a terceira nota do aluno: ");
            nota3 = double.Parse(Console.ReadLine());

            if ((nota1 > nota2) && (nota1 > nota3))
            {
                maior = nota1;
            }
            else if ((nota2 > nota1) && (nota2 > nota3))
            {
                maior = nota2;
            }
            else
            {
                maior = nota3;
            }

            Console.WriteLine($"Maior nota: {maior}");

            Console.ReadKey();
        }
    }
}
