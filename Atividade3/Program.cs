using System;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            static double PercentOf(Double salario, double percent)
            {
                return (percent/100.0) * salario;
            }
            double percent = 0;
            double salario = 0;
            Console.WriteLine("Insira o salário bruto: ");
            salario = Convert.ToDouble(Console.ReadLine());
            if (salario < 2000)
            {
                Console.WriteLine("O salário reduzido de passagem será = " + PercentOf(94, salario) + " havendo uma redução de "+PercentOf(6,salario));
                Console.WriteLine("O salário reduzido do INSS será = " + PercentOf(89, salario) + " havendo uma redução de " + PercentOf(11, salario));
                Console.WriteLine("O salário reduzido de ambos será = " + PercentOf(83.66, salario) + " havendo uma redução de " + PercentOf(16.34, salario));
            }
            if (salario >= 2000)
            {
                Console.WriteLine("O salário reduzido de passagem será = " + PercentOf(94, salario) + " havendo uma redução de " + PercentOf(6, salario));
                Console.WriteLine("O salário reduzido do INSS será = " + PercentOf(89, salario) + " havendo uma redução de " + PercentOf(11, salario));
                Console.WriteLine("O salário reduzido do Imposto de renda será = " + PercentOf(92, salario) + " havendo uma redução de " + PercentOf(8, salario));
                Console.WriteLine("O salário reduzido de ambos será = " + PercentOf(76.967, salario) + " havendo uma redução de " + PercentOf(23.033, salario));
            }
        }
    }
}
