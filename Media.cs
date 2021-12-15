using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeMediaPOO
{
    public class Media
    {

        double nota1 { get; set; }
        double nota2 { get; set; }
        double nota3 { get; set; }
        double nota4 { get; set; }
        double media { get; set; }


        public void inserirNota()
        {
            Console.Write("Informe a Primeira Nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a Segunda Nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Informe a Terceira Nota: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Informe a Quarta Nota: ");
            nota4 = double.Parse(Console.ReadLine());
        }

        public void calcularMedia()
        {
            media = (nota1 + nota2 + nota3 + nota4) / 4;           
        }

        public void exibirMedia()
        {
            if (media < 4)
            {
                Console.WriteLine("Aluno Retido");
            }
            else if (media >= 4 && media < 7)
            {
                Console.WriteLine("Aluno em Recuperação");
            }
            else
            {
                Console.WriteLine("Aluno Aprovado");
            }
        }
    }
}
