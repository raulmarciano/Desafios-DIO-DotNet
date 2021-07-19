

using System;

internal class Desafio
{
    private static void Main()
    {
        //declare suas variaveis corretamente
        double notaDigitada;
        double? primeiraNota = null;
        double? segundaNota = null;
        double media;

        int opcaoSelecionada = 1;
        //continue a solução ou implemente da sua maneira

        while (opcaoSelecionada != 2)
        {
            notaDigitada = Convert.ToDouble(Console.ReadLine());

            if (notaDigitada < 0 || notaDigitada > 10)
            {
                Console.WriteLine("nota invalida");
                continue;
            }
            else if (primeiraNota == null)
            {
                primeiraNota = notaDigitada;
                continue;
            }
            else
            {
                segundaNota = notaDigitada;
            }

            media = (double)(primeiraNota + segundaNota) / 2;

            Console.Write("media = ");
            Console.WriteLine(media.ToString("N2"));

            do
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                opcaoSelecionada = Convert.ToInt32(Console.ReadLine());
            } while (opcaoSelecionada < 1 || opcaoSelecionada > 2);

            primeiraNota = segundaNota = null;
        }
    }
}