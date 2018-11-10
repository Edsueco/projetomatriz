using System;

namespace projetomatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] nome = new string[2, 2];
            string conteudo="";

            for (int i = 0; i< 2; i++){
                for (int j = 0; j < 2; j++){
                    if (j == 0) Console.WriteLine("INFORME O NOME:");
                    if (j == 1) Console.WriteLine("INFORME O SOBRNOME:");
                    nome[i, j] += Console.ReadLine() + " ";
                    conteudo += nome[i, j];
                }
                conteudo += "\n";
            }
            Console.WriteLine(conteudo);
        }
    }
}
