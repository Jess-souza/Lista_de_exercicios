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
                Console.WriteLine("(3) Calculo de volume");
                Console.WriteLine("(4) Aprovados ou reprovados");
                Console.WriteLine("(5) Controle de animais");
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
                        float nota1, nota2, nota3, media, notae, mediae;

                        Console.WriteLine("Informe a primeira nota: ");
                        nota1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a segunda nota: ");
                        nota2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a terceira nota: ");
                        nota3 = float.Parse(Console.ReadLine());

                        media = (nota1 + nota2 + nota3) / 3;
                        if (media >= 7)
                        {
                            Console.WriteLine("Aprovado, média {0}", Math.Round(media, 1));
                        }
                        else
                        {
                            Console.WriteLine("Informe a nota do exame: ");
                            notae = float.Parse(Console.ReadLine());

                            mediae = (nota1 + nota2 + nota3 + notae) / 4;

                            if (mediae >= 5)
                            {
                                Console.WriteLine("Aprovado em exame, média {0}", Math.Round(mediae, 1));
                            }
                            else
                            {
                                Console.WriteLine("Reprovado, média {0}", Math.Round(mediae, 1));
                            }
                        }
                        break;
                    case 5:
                        Animal a1 = new Animal();
                        Animal a2 = new Animal();
                        Animal a3 = new Animal();
                        Animal a4 = new Animal();
                        Animal a5 = new Animal();
                        int tlCachorro = 0, tlGato = 0, tlPeixe = 0;

                        //Primeiro animal
                        Console.Write("Informe o nome do primeiro animal: ");
                        a1.Nome = Console.ReadLine();
                        Console.Write("Informe o tipo do primeiro animal (Cachorro, Gato ou Peixe): ");
                        a1.Tipo = Console.ReadLine();

                        if (a1.Tipo == "Cachorro") tlCachorro++;
                        if (a1.Tipo == "Gato") tlGato++;
                        if (a1.Tipo == "Peixe") tlPeixe++;

                        //Segundo animal
                        Console.Write("Informe o nome do segundo animal: ");
                        a2.Nome = Console.ReadLine();
                        Console.Write("Informe o tipo do segundo animal (Cachorro, Gato ou Peixe): ");
                        a2.Tipo = Console.ReadLine();

                        if (a2.Tipo == "Cachorro") tlCachorro++;
                        if (a2.Tipo == "Gato") tlGato++;
                        if (a2.Tipo == "Peixe") tlPeixe++;

                        //Terceiro animal
                        Console.Write("Informe o nome do terceiro animal: ");
                        a3.Nome = Console.ReadLine();
                        Console.Write("Informe o tipo do terceiro animal (Cachorro, Gato ou Peixe): ");
                        a3.Tipo = Console.ReadLine();

                        if (a3.Tipo == "Cachorro") tlCachorro++;
                        if (a3.Tipo == "Gato") tlGato++;
                        if (a3.Tipo == "Peixe") tlPeixe++;

                        //Quarto animal
                        Console.Write("Informe o nome do quarto animal: ");
                        a4.Nome = Console.ReadLine();
                        Console.Write("Informe o tipo do quarto animal (Cachorro, Gato ou Peixe): ");
                        a4.Tipo = Console.ReadLine();
                        if (a4.Tipo == "Cachorro") tlCachorro++;
                        if (a4.Tipo == "Gato") tlGato++;
                        if (a4.Tipo == "Peixe") tlPeixe++;

                        //Quinto animal
                        Console.Write("Informe o nome do quinto animal: ");
                        a5.Nome = Console.ReadLine();
                        Console.Write("Informe o tipo do quinto animal (Cachorro, Gato ou Peixe): ");
                        a5.Tipo = Console.ReadLine();

                        if (a5.Tipo == "Cachorro") tlCachorro++;
                        if (a5.Tipo == "Gato") tlGato++;
                        if (a5.Tipo == "Peixe") tlPeixe++;

                        Console.WriteLine("O total de animais é Cachorros: {0}, Gatos: {1} e Peixes: {3}", tlCachorro, tlGato, tlPeixe);
                        break;
                    case 6:
                        validacao = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
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
