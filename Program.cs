using System; //O system é um import padrão tornando desnecessário ter de importar em todo arquivo.
using MeuApp.Teste; //Com o uso de namespacings podemos usar elas como "using" e importa-las em outras classes.

namespace MeuApp
{
    class Program
    {

        struct Product
        {
            public int id;
            public float valor;

            public Product(int id, float valor)
            {
                this.id = id;
                this.valor = valor;
            }
        };
        static void Main(string[] args)
        {
            /*
            VARIAVEIS: Recebem constante variação
            convenção de nomenclatura: var palavraPalavra;

                int idade;          inicia com ZERO
                int idade = 25;     inicia com 25
                var idade = 25;     inicia com 25
                var idade;          ERRO
            */

            /*
            CONSTANTES: Não possuem reatribuição de valor e seu valor se da quando a constante é iniciada
            convenção de nomenclatura: const <tipo> PALAVRA_PALAVRA;

                const int IDADE_MINIMA;         inicia com zero 
                const int IDADE_MINIMA = 18;    inicia com 18
                const var IDADE_MINIMA;         ERRO
            */

            /*
            DECLARAÇÃO DE PONTOS FLUTUANTES: 
            Se não for especificado qual dos três tipos primitivos de ponto flutuante é, o C# define como padrão double 

                var salario = 2.500;        definido como double
                float salario = 2500f;      definido como float necessitando o f
                decimal salario = 2500m;    definido como decimal necessitando o m
            */

            /*
            NULL TYPE:
            Variáveis podem possuir valor vazio. Todo tipo primitivo pode ser nullable, basta colocar uma ? após a declaração

                int? idade = null;
                string? nome = null || string nome = [];
            */

            /*
            CONVERSÃO EXPLÍCITA:

               int inteiro = 100;
               uiny inteiroSemSinal = (uint)inteiro;
            */

            /*
            PARSE:
            Qualquer tipo de dado numérico possui um método chamado Parse, que espera uma cadeia 
            de caracteres e que vai converter essa cadeia de caracteres para o tipo um numero

                int inteiro = int.Parse("100");
            */

            var texto = "Hello, world!";

            Console.WriteLine(texto);

            int? idadeNull = null;
            int idadeIni = 0;

            Console.WriteLine("\n\nVar ainda não recebeu valor: " + idadeNull);
            Console.WriteLine("\nVar já foi inicializada como zero: " + idadeIni);

            //Inicializar variáveis como null é útil caso seja necessário testar caso seja empty ou não

            if (idadeNull == null)
            {
                Console.WriteLine("\nÉ nulo");
            }

            if (idadeIni == 0)
            {
                Console.WriteLine("\nNão nulo");
            }

            int inteiro = 100;
            float real = 25.5f;

            // real = inteiro;         //implícito
            // inteiro = (int)real;    //explícito

            inteiro = int.Parse("1000");

            string realString = real.ToString(); //O método ToString converte qualquer varíavel para uma string

            inteiro = Convert.ToInt32(real); //Vai arredondar para cima

            Console.WriteLine(inteiro);

            string valor = "bruno";

            switch (valor)
            {
                case "henrique":
                    Console.WriteLine("não é o cara!");
                    break;

                case "marcelo":
                    Console.WriteLine("Não é o cara!");
                    break;

                case "bruno":
                    Console.WriteLine("É o cara!");
                    break;

                default:
                    Console.WriteLine("Not found :(");
                    break;
            }

            int numero = 1;

            switch (numero)
            {
                case 1:
                    Console.WriteLine("1");
                    break;

                case 2:
                    Console.WriteLine("2");
                    break;

                case 3:
                    Console.WriteLine("3");
                    break;

                default:
                    Console.WriteLine("Not found :(");
                    break;
            }

            MeuMetodo();
        }

        static void MeuMetodo()
        {
            var product = new Product();

            product.id = 1;

            Console.WriteLine("id: " + product.id);
        }
    }
}