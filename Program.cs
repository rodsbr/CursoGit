using System;
using System.Globalization;



namespace Course {
    class Program {
        static void Main(string[] args) {
            int[,] mat;

            Console.Write("Digite o numero de linhas da Matriz: ");
            int n = int.Parse(Console.ReadLine());
             //qualquer coisa aqyu
            mat = new int[n, n];
            int neg = 0;

            for (int i = 0; i <= mat.Rank; i++) {
                for (int j = 0; j < mat.GetLength(1); j++) {
                    Console.Write($"Insira o valor #{i},{j} da Matriz: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                    if (mat[i, j]<0) {
                        neg++;
                    }
                }
            }

            Console.WriteLine("--------------------------------------------");


            for (int i = 0; i <= mat.Rank; i++) {
                for (int j = 0; j < mat.GetLength(1); j++) {

                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Diagonal Principal:");

            for (int i = 0; i <= mat.Rank; i++) {                
                    Console.Write(mat[i, i] + " ");               
                
            }
            Console.WriteLine();
            Console.WriteLine("Numeros Negativos: " + neg); ;






        }
    }
}
