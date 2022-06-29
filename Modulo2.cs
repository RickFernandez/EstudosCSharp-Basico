namespace HelloWord
{
    internal class Modulo2
    {
        // ESTUDO SOBRE OPERADORES E LAÇOS DE REPETIÇÕES

        static void Main()
        {
            int x = 5;
            Math.Pow(x, 2); // x²
            Console.WriteLine(x);

            int y = 25 % 2; //Retorna o resto da divisão de 25/2 = 1
            Console.WriteLine(y);

            double nota1 = 8.0;
            double nota2 = 9.0;
            Console.WriteLine("Nota maior que 7? {0}", nota1 > 7.0);
            Console.WriteLine("Tirou 10? {0}", nota2 == 10.0);

            Console.WriteLine("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            Console.WriteLine("Nota maior que 7? {0}", nota > 7.0);
            Console.WriteLine("Tirou 10? {0}", nota == 10.0);

            var atividade1 = true;
            var atividade2 = false;
            var todasAtividades = atividade1 && atividade2;
            var umaAtividade = atividade1 || atividade2;

            Console.WriteLine("Fez todas as atividades? {0}", todasAtividades);
            Console.WriteLine("Fex pelo menmos uma das atividades? {0}", umaAtividade);
            Console.WriteLine("Não fez nenhum atividade? {0}", !umaAtividade);

            var a = false;
            var n1 = 6;
            var n2 = 5;
            var n3 = 7;
            var n4 = 8;

            Console.WriteLine(!a);
            n3++;
            Console.WriteLine(n3);
            n4--;
            Console.WriteLine(n4);

            Console.WriteLine(n2 == --n1);
            Console.WriteLine(n2-- == ++n1);

            var ie1 = 5;
            var ie2 = 9;
            var ie3 = 10;

            // ESTRUTURA IF-ELSE

            if (ie1 < ie2)
            {
                Console.WriteLine("Condição 1 é satisfeita!");
                Console.WriteLine("Resultado da soma é: {0}", ie1 + ie2);
            }
            else if (ie3 < ie2)
            {
                Console.WriteLine(ie3 + ie2);
            }
            else
            {
                Console.WriteLine("Condição 2 não é satisfeita!");
            }

            // ESTRUTURA SWITCH 

            Console.WriteLine("Qual nota você gostaria de dar para este prato? 0, 5, ou 10");
            int.TryParse(Console.ReadLine(), out int notaPrato);

            switch (notaPrato)
            {
                case 0:
                    Console.WriteLine("Comida muito ruim");
                    break;
                case 5:
                    Console.WriteLine("Comida razoável");
                    break;
                case 10:
                    Console.WriteLine("Comida muito boa");
                    break;
                default:
                    Console.WriteLine("Nota inexistente");
                    break;
            }


            // ESTRUTURA WHILE

            var w1 = 1;

            while(w1 <= 10)
            {
                Console.WriteLine(w1);
                w1++;
            }

            // ESTRUTURA FOR

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
