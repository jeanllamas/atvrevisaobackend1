using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

public class Exercicio2
{
    public static void Main()
    {
        // Exercício 2A - Array de Convidados
        string[] a_convidados = new string[5];
        a_convidados[0] = "Ana";
        a_convidados[1] = "Luiza";
        a_convidados[2] = "Paulo";
        a_convidados[3] = "Rogério";
        a_convidados[4] = "Catarina";

        Console.Write("Array de Convidados: ");
        foreach (var nome in a_convidados)
        {
            Console.Write(nome + ", ");
        }

        // Exercício 2B - Lista de Convidados
        List<string> l_convidados = new List<string>();
        l_convidados.Add("Bruno");
        l_convidados.Add("Stella");
        l_convidados.Add("Sabrina");
        l_convidados.Add("Vicente");
        l_convidados.Add("Marcelo");

        Console.Write("\n\nLista de Convidados: ");
        foreach (var nome in l_convidados)
        {
            Console.Write(nome + ", ");
        }
    }
}
