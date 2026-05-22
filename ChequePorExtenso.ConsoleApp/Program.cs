string[] unidade = {
    "", "Um", "Dois", "Três", "Quatro",
    "Cinco", "Seis", "Sete", "Oito", "Nove"
};

string[] excecao = {
    "Dez", "Onze", "Doze", "Treze", "Quatorze",
    "Quinze", "Dezesseis", "Dezessete",
    "Dezoito", "Dezenove"
};

string[] dezena = {
    "", "", "Vinte", "Trinta", "Quarenta",
    "Cinquenta", "Sessenta", "Setenta",
    "Oitenta", "Noventa"
};

string[] centena = {
    "", "Cento", "Duzentos", "Trezentos",
    "Quatrocentos", "Quinhentos",
    "Seiscentos", "Setecentos",
    "Oitocentos", "Novecentos"
};

Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

int resto = numero % 1000;
int milhar = numero / 1000;
int centenaNumero = resto / 100;
int dezenaNumero = (resto % 100) / 10;
int unidadeNumero = resto % 10;

if (milhar > 0)
{
    if (milhar < 10)
    {
        Console.Write($"{unidade[milhar]} mil ");
    }

    else if (milhar >= 10 && milhar <= 19)
    {
        Console.Write($"{excecao[milhar - 10]} mil ");
    }

    else
    {
        int dezenaMilhar = milhar / 10;
        int unidadeMilhar = milhar % 10;

        Console.Write($"{dezena[dezenaMilhar]}");

        if (unidadeMilhar > 0)
            Console.Write($" e {unidade[unidadeMilhar]}");

        Console.Write(" mil " );
    }
}

if (resto == 100)
{
    Console.Write("Cem");
}

else
{
    if (centenaNumero > 0)
    {
        Console.Write($"{centena[centenaNumero]}");
    }

    if (dezenaNumero == 1)
    {
        if (centenaNumero > 0)
            Console.Write(" e ");

        Console.Write($"{excecao[unidadeNumero]}");
    }

    else
    {
        if (dezenaNumero > 1)
        {
            if (centenaNumero > 0)
                Console.Write(" e ");

            Console.Write($"{dezena[dezenaNumero]}");
        }

        if (unidadeNumero > 0)
        {
            if (centenaNumero > 0 || dezenaNumero > 1)
                Console.Write(" e ");

            Console.Write($"{unidade[unidadeNumero]}");
        }
    }
}

if (numero == 1)
    Console.WriteLine(" real");

else    
    Console.WriteLine(" reais");

Console.WriteLine("---------------------------------"); 
Console.WriteLine("Digite enter para continuar..."); 
Console.WriteLine("---------------------------------"); 

