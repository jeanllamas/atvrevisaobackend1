using System;
using System.Net.NetworkInformation;

public class Exercicio3
{
    public static void Main()
    {
        List<string> frutas = new List<string>();

        Console.WriteLine("Insira nomes de frutas (separe-as apenas por vírgula, sem espaço): ");
        string entrada = Console.ReadLine();

        entrada += ",";// Acrescenta uma vírgula ao final da string de entrada para facilitar verificação

        while (entrada.IndexOf(",") != -1)// Checa se a fruta está repetida na string de entrada
        {
            string fruta = entrada.Substring(0, entrada.IndexOf(","));// Separa a palavra que está antes da primeira vírgula

            entrada = entrada.Remove(0, (entrada.IndexOf(",")+1));// Tira a fruta da string de entrada
            
            while(entrada.IndexOf(fruta) != -1)// Verifica se a fruta está repetida ao longo da string de entrada
            {
                int pos_fruta = entrada.IndexOf(fruta);// Encontra a posição da duplicata
                entrada = entrada.Remove(pos_fruta, (fruta.Length+1));// Remove da string de entrada
            }

            frutas.Add((fruta.Substring(0, 1)).ToUpper() + fruta.Substring(1));
            // Acrescenta a fruta à lista e transforma o primeiro caractere em maiúsculo

        }

        frutas.Sort();// Organiza as frutas em ordem alfabética

        Console.WriteLine("\nFrutas colocadas na lista:");
        foreach (var i in frutas)// Imprime cada fruta na lista
        {
            Console.WriteLine(i);
        }
    }
}
