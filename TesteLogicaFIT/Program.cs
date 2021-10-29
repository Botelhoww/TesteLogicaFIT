using System;

namespace TesteLogicaFIT
{
    class Program
    {
        static void Main(string[] args)
        {
            NumerosPrimos();

            //retorna false
            Palindromo("Sextou".ToUpper());

            //retorna true
            Palindromo("A base do teto desaba");


        }

        #region Exercicio: Números Primos
        public static void NumerosPrimos()
        {
            int num;
            int div = 0;
            int iter = 0;

            //Solicitando o número inteiro
            Console.Write("Digite o número inteiro: ");
            //Realiza a leitura do número
            num = Convert.ToInt32(Console.ReadLine());

            //Verifica a qtd de divisores do número
            for (int i = 1; i <= num; i++)
            {
                //cada iteração que tiver, adiciona o valor na variavel
                iter++;

                //Verifica se é divisor
                if (num % i == 0)
                {
                    div++;
                }
            }

            if (div == 2)
                Console.WriteLine($"O número {num} é primo. Número de iterações necessárias: {iter}");
            else
                Console.WriteLine($"O número {num} não é primo. Número de iterações necessárias: {iter}");
        }
        #endregion

        #region Exercicio: Palindromo

        public static bool Palindromo(string pFrase)
        {
            Console.WriteLine($"Verificando se a frase: {pFrase} é um palindromo");

            string fraseOri = pFrase;
            bool retorno = false;

            pFrase = pFrase.ToUpper();
            pFrase = pFrase.Replace(" ","");

            int x = pFrase.Length - 1;

            while (x != -1)
            {
                for (int i = 0; i < pFrase.Length; i++)
                {
                    if (pFrase[i] == pFrase[x])
                    {
                        if (x == 0)
                        {
                            retorno = true;
                            Console.WriteLine(retorno);
                            Console.WriteLine($"a palavra {fraseOri} é um palindromo!");
                        }

                        x--;
                    } else
                    {
                        retorno = false;
                        Console.WriteLine(retorno);
                        Console.WriteLine($"a palavra {fraseOri} não é um palindromo!");

                        i = pFrase.Length;
                        x = -1;
                    }
                }
            }

            return retorno;
        }

        #endregion

        //não obtive sucesso ao realizar esse exercicio
        #region Exercicio: Robô


        public static bool Robo()
        {
            bool retorno = false;

            //coord iniciais
            int x1 = 1;
            int y1 = 1;

            //coord finais
            int x2 = 5;
            int y2 = x1 + y1;

            for (int i = 0; i < x2; i++)
            {
                //⦁	Da posição (x, y) para a posição (x + y, y).
                //⦁	Da posição(x, y) para a posição(x, x + y).

            }



            return retorno;
        }

        #endregion
    }
}
