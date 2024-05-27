using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstraindoCelularPoo.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }
        private List<string> Contatos { get; set; }



        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades

            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;


            Contatos =
            [
                "Ana Beatriz",
                "Beto Maia",
                "Cláudio Humberto",
                "Leonardo Buta",
                "Mauro Silva",
                "Paula Souza",
                "Tia Zélia",
            ];
        }

        public void Ligar()
        {
            Console.WriteLine($"******* Realizando ligação ********");
            Console.WriteLine($" {Contatos[new Random().Next(Contatos.Count)]}\n");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"******** Recebendo ligação ********");
            Console.WriteLine($" {Contatos[new Random().Next(Contatos.Count)]}\n");
        }

        public abstract void InstalarAplicativo(string nomeApp);


        public void ListarContatos()
        {
            Console.WriteLine("************** Contatos ***********");
            foreach (string contato in Contatos)
            {
                Console.WriteLine($"@ {contato}");
            }
            Console.WriteLine("");
        }

        public void MostrarSobre()
        {
            Console.WriteLine("********* Sobre o telefone ********");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Nº do telefone: {Numero}");
            Console.WriteLine($"IMEI: {Imei}");
            Console.WriteLine($"Memória: {Memoria} GB\n");
        }
    }
}