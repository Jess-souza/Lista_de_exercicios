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
                Console.WriteLine("(2) Salário");
                Console.WriteLine("(3) Calculo do raio");
                Console.WriteLine("(4) Alunos aprovados ou reprovados");
                Console.WriteLine("(5) Animais de estimação");
                Console.WriteLine("(6) Sair");

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
                            Console.WriteLine(" O resultado do IMC: {0}, pessoa abaixo do peso. ", Math.Round(result, 2));
                        }
                        if (result >= 20  & result <  25 )
                        {
                            Console.WriteLine(" O resultado do IMC: {0}, pessoa com peso ideal. ", Math.Round(result, 2));
                        }
                        if (result >= 25)
                        {
                            Console.WriteLine(" O resultado do IMC: {0} pessoa acima do peso. ", Math.Round(result, 2));
                        }
                        break;
                    case 2:
                        float salf, salm, total;

                        Console.WriteLine("Digite o valor do salário do funcionário: ");
                        salf = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor do salário mínimo: ");
                        salm = float.Parse(Console.ReadLine());

                        total = salf / salm;

                        Console.WriteLine("O funcionário recebe o valor correspondete a {0} salário(s) mínimo(s).", Math.Round(total, 1));
                        break;
                    case 3:
                        double raio, volume;

                        Console.WriteLine("Digite o valor do raio: ");
                        raio = double.Parse(Console.ReadLine());

                        volume = 4 * 3.14 * raio * raio * raio / 3;

                        Console.WriteLine("O valor do volume conforme raio informado é de {0}:", Math.Round(volume, 2));
                        break;
                    case 4:
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
