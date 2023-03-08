using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

public class Exercicio1
{
    public static void Main()
    {
        int convidadosNoivo = 34;
        int convidadosNoiva = 46;
        int convidadosPresentesNoivo = 38;
        int convidadosPresentesNoiva = 44;

        //inserir codigo do aqui…
        bool resultado;

        if (resultado = convidadosNoiva < convidadosNoivo)
        { Console.WriteLine($"A noiva convidou menos pessoas que o noivo ({convidadosNoiva} < {convidadosNoivo})\n"); }

        if (resultado = convidadosNoiva > convidadosNoivo)
        { Console.WriteLine($"A noiva convidou mais pessoas que o noivo ({convidadosNoiva} > {convidadosNoivo})\n"); }

        if (resultado = convidadosNoivo <= 35)
        { Console.WriteLine($"O noivo convidou menos de ou exatamente 35 pessoas ({convidadosNoivo} convidados por ele)\n"); }

        if (resultado = convidadosNoiva >= 35)
        { Console.WriteLine($"A noiva convidou mais de ou exatamente 35 pessoas ({convidadosNoiva} convidados por ela)\n"); }

        if (resultado = convidadosNoiva == convidadosNoivo)
        { Console.WriteLine($"A noiva convidou a mesma quantidade de pessoas que o noivo ({convidadosNoiva} convites de cada)\n"); }

        if (resultado = convidadosNoiva != convidadosNoivo)
        { Console.WriteLine("A noiva não convidou a mesma quantidade de pessoas que o noivo " +
            $"(Ela convidou {convidadosNoiva} e ele, {convidadosNoivo})\n"); }

        if (resultado = convidadosPresentesNoiva > convidadosNoiva || convidadosNoivo < convidadosPresentesNoivo)
        { Console.WriteLine("Vieram mais pessoas além das convidadas " +
            $"\n(Das {convidadosNoiva} pessoas convidadas pela noiva vieram {convidadosPresentesNoiva} " +
            $"\ne das {convidadosNoivo} pessoas convidadas pelo noivo vieram {convidadosPresentesNoivo})\n"); }

        if (resultado = convidadosPresentesNoiva < convidadosNoiva && convidadosPresentesNoivo > convidadosNoivo)
        { Console.WriteLine("Há menos convidados da noiva presentes e mais pessoas presentes que convidados pelo noivo"); }
    }
}
