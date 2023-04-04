using System;

namespace Floricultura
{
    internal class Program // responsável por rodar o programa, contém Menu. Abrir nova classe para escrever atributo das plantas e não ficar cheio de informação dentro do código.
                  /*int numero = 2;
                    numero = numero + 5;
                    Console.WriteLine(numero);o numero passa a ter o valor de 7.
                  */
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Digite um inteiro para saber sua metade:");
            int teste = Convert.ToInt32(Console.ReadLine());
            double numeroEscolhido = CalculaMetade(teste);
            Console.WriteLine($"a metade é: {numeroEscolhido}");
            */
            //double metade = CalculaMetade(5);

            MenuPlantas();//stpe over: Mostrar Menu, ele vai para próxima linha. Step into: entra em MenuPlanta();.

            bool mostraMenu = true; // verdadeiro seria opção 1 e 2 porque ainda quero mostrar o menu, mas se ela não quiser mais responder precisa mudar a condição para falso, e esa opção estará quando ela digitar 3, que é a opção sair do menu.
            while (mostraMenu)
            {
                string resposta = Console.ReadLine(); // precisa ler a resposta do usuário e colocar em uma variável
                switch (resposta)
                {
                    case "1":
                        //Cadastrar a planta
                        Planta plantaCadastradada = new Planta();

                        plantaCadastradada = plantaCadastradada.CadastroPlanta(plantaCadastradada);




                        mostraMenu = true;
                        MenuPlantas();
                        break;
                    case "2":
                        //Limpar console
                        Console.Clear();
                        mostraMenu = true;
                        MenuPlantas();
                        break;
                    case "3":
                        //Sair
                        mostraMenu = false;
                        break;//para voltar para o while. Para quebrar fora do switch
                    default: //Quando as opções dadas não foram a resposta do usuário. No exemplo, se o usuário digitou 5.
                        //mensagem de erro, dá opção de digitar novamente
                        Console.Write("Opção inválida. Digite novamente:");
                        mostraMenu = true;
                        MenuPlantas();
                        break;
                }

            }

        }

        private static void MenuPlantas() //porque não tenho nenhuma entrada. entrada vazia, parenteses vazio
        {
            Console.WriteLine($"\nDigite 1 para cadastrar uma planta:"); //ctrl + C copia a linha anterior sem precisar selecionar
            Console.WriteLine($"Digite 2 para limpar console:");
            Console.WriteLine($"Digite 3 para sair do programa:");

        }


        private static double CalculaMetade(int numero)
        {
            Console.WriteLine($"entrada: {numero}");
            double metadeValor = 0;
            metadeValor = numero / 2;
            Console.WriteLine($"saida: {metadeValor}");

            return metadeValor;
        }


    }
}
