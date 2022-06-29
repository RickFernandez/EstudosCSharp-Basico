using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class Modulo3
    {
        static void Main()
        {
            // DESAFIO CALCULAR MÉDIA DE NOTAS
            Console.WriteLine(" ===== DESAFIO MÉDIA DE NOTAS =====");

            float media;

            Console.WriteLine("Digite a primeira nota:");
            int.TryParse(Console.ReadLine(), out int n1);

            Console.WriteLine("Digite a segunda nota:");
            int.TryParse(Console.ReadLine(), out int n2);

            Console.WriteLine("Digite a terceira nota:");
            int.TryParse(Console.ReadLine(), out int n3);

            media = (n1 + n2 + n3) / 3;

            Console.WriteLine("A média final deste aluno foi: {0}", media);

            if (media >= 7)
            {
                Console.WriteLine("Parabéns, este aluno foi aprovado!!");
            }
            else
            {
                Console.WriteLine("Infelizmente este aluno foi reprovado...");
            }

            // DESAFIO SOMA DE VALORES
            Console.WriteLine(" ===== DESAFIO SOMA DE VALORES =====");

            Boolean opcao = true;

            Console.WriteLine("Digite um número inicial:");
            float.TryParse(Console.ReadLine(), out float inicial);

            while(opcao == true)
            {
                Console.WriteLine("Digite o número que deseja somar ao número inicial");
                float.TryParse(Console.ReadLine(), out float numero);
                inicial += numero;

                Console.WriteLine("O total da soma áté o momento é: {0}", inicial);
                Console.WriteLine("Deseja continuar? <1> sim - <2> não");
                int.TryParse(Console.ReadLine(), out int resposta);

                switch (resposta)
                {
                    case 1:
                        Console.WriteLine("Continuar Soma");
                        break;
                    case 2:
                        Console.WriteLine("Saindo do Programa...");
                        opcao= false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;

                }
            }



        }
    }
}
