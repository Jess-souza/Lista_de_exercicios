using System;

namespace Lista_de_exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            bool validacao = true;
            
            do
            {
                Console.WriteLine("Qual exercício desejado?");
                Console.WriteLine("(1) IMC");
                Console.WriteLine("(2) MediaSalário");
                Console.WriteLine("(3) Calculo do raio");
                Console.WriteLine("(4) Alunos aprovados ou reprovados");
                Console.WriteLine("(5) Animais de estimação");
                Console.WriteLine("(5) Sair");

                Console.WriteLine("Digite a sua opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        float n1, n2, result;
                        
                        Console.WriteLine("Digite seu peso (Kg): ");
                        n1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite sua altura (m): ");
                        n2 = float.Parse(Console.ReadLine());

                        result = n1 / (n2 * n2);
                        if (result < 20)
                        {
                            Console.WriteLine("O resultado do IMC: {0}, pessoa abaixo do peso.", Math.Round(result, 2));
                        }
                        if (result >= 20 & result < 25)
                        {
                            Console.WriteLine("O resultado do IMC: {0}, pessoa com peso ideal.", Math.Round (result, 2));
                        }
                        if (result >= 25)
                        {
                            Console.WriteLine("O resultado do IMC: {0} pessoa acima do peso.", Math.Round(result, 2));
                        }
                        break;
                }
                Console.WriteLine("Aperte Enter para continuar");
                Console.ReadLine();
                Console.Clear();
            } while (validacao);
            {
            }
        }
            
    }
}
