using System;
using System.Collections.Generic;
using System.Text;

namespace Floricultura
{
    internal class Planta
    {
        /*atributos: 
        nome
        preço
        frequência rega
        porte
        sombra/sol
        tóxica
        */
        string nome;
        double preco;
        int rega;
        List<string> porte = new List<string>();
        enum luminosidade
        {
            SolPleno,
            MeiaSombra,
            Sombra
        }
        bool toxicidade;
        public Planta()
        {
            porte.Add("P");
            porte.Add("M");
            porte.Add("G");
        } //string nome, double preco, int rega

        //tipo retorno vai ser uma classe, nesse caso planta. Ela passa ser um objeto. Vamos ter todas as informações, seja ela string, bool, double... tudo dentro de Planta.
        public Planta CadastroPlanta(Planta plantaAtualizar)
        {
            //Console.WriteLine("\nDigite o nome da planta:");
            //plantaAtualizar.nome = Console.ReadLine();
            //Console.WriteLine($"O nome da sua planta é {plantaAtualizar.nome}");

            plantaAtualizar.nome = NomePlanta();

            plantaAtualizar.preco = ValorPlanta(plantaAtualizar.nome);

            plantaAtualizar.toxicidade = PlantaToxica(plantaAtualizar.nome, plantaAtualizar.preco);

            //List<string> regaDoDia = PlantasParaRegar();

            //Console.WriteLine("\nDigite o valor da planta:");
            //plantaAtualizar.preco = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"O valor de {plantaAtualizar.nome} é {plantaAtualizar.preco}");

            /*Console.WriteLine("\nA planta é tóxica? Responda \"sim\" ou \"não\"");
            string plantaToxica = Console.ReadLine();
            
            if (plantaToxica == "sim")
            {
                plantaAtualizar.toxicidade = true;
                Console.WriteLine("\nA planta selecionada é tóxica");
            }
            else if (plantaToxica == "não")
            {
                plantaAtualizar.toxicidade = false;
                Console.WriteLine("\nA planta selecionada não é tóxica");
            }
            else
            {
                Console.WriteLine("\n Erro. Digite novamente:");
            }

            */
            return plantaAtualizar;
        }

        public string NomePlanta()
        {
            Console.WriteLine("\nDigite o nome da planta:");
            string nomeDaPlanta = Console.ReadLine();
            Console.WriteLine($"O nome da sua planta é {nomeDaPlanta}");
            return nomeDaPlanta;
        }

        public List<string> PlantasParaRegar() 
        {
            Console.WriteLine("\nvamos regas as plantas:");

            string plantaRegada1 = NomePlanta();

            string plantaRegada2 = NomePlanta();

            string plantaRegada3 = NomePlanta();

            List<string> plantasRegadas = new List<string>();
            plantasRegadas.Add(plantaRegada1);
            plantasRegadas.Add(plantaRegada2);
            plantasRegadas.Add(plantaRegada3);
            return plantasRegadas;
        }

        public double ValorPlanta(string nomePlanta)
        {
            Console.WriteLine("\nDigite o valor da planta:");
            double valorDaPlanta = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"O valor de {nomePlanta} é {valorDaPlanta}");
            return valorDaPlanta;
        }

        public bool PlantaToxica(string nomePlanta, double valorDaPlanta) 
        {
            Console.WriteLine("\nA planta é tóxica? Responda \"sim\" ou \"não\"");
            string plantaToxica = Console.ReadLine();//o que o usuario respondeu
            bool plantaToxicidade = false;

            if (plantaToxica == "sim")
            {
                plantaToxicidade = true;
                Console.WriteLine($"\nA planta {nomePlanta} tem o valor de {valorDaPlanta} e é tóxica");
            }
            else if (plantaToxica == "não")
            {
                plantaToxicidade = false;
                Console.WriteLine($"\nA planta {nomePlanta} tem o valor de {valorDaPlanta} e não é tóxica");
            }
            else
            {
                Console.WriteLine("\n Erro. Digite novamente:");
            }


            return plantaToxicidade;
        }

    }




}
