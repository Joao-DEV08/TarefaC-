using System;
public class Exercicio1
{
    public static void Main()
    {
        int convidadosNoivo = 300;
        int convidadosNoiva = 600;
        int convidadosPresentesNoivo = 405;
        int convidadosPresentesNoiva = 400;

        //inserir codigo do aqui…

        if(convidadosNoivo > convidadosNoiva)
        {
            Console.WriteLine("O nº de convidados do noivo é maior que o da noiva");
        }else
        {
            Console.WriteLine("O nº de convidados da noiva é maior que o do noivo");
        }

        if(convidadosPresentesNoivo > convidadosPresentesNoiva)
        {
            Console.WriteLine("Existem penetras, pois existem mais conviados do noivo do que da noiva");
        }
        else
        {
            Console.WriteLine("Existem penetras, pois existem mais conviados da noiva do que do noivo");
        }
    }
};
