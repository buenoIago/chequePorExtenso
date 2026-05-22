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
int milharNumero = (numero / 1000) % 1000;
int milhaoNumero = numero / 1000000;

if (milhaoNumero > 0)
{
    int centenaNumeroMilhao = milhaoNumero / 100;
    int dezenaNumeroMilhao = (milhaoNumero % 100) / 10;
    int unidadeNumeroMilhao = milhaoNumero % 10;

    if (milhaoNumero == 100)
    {
        Console.Write("Cem milhões ");
    }

    else
    {
        if (centenaNumeroMilhao > 0)
        {
            Console.Write($"{centena[centenaNumeroMilhao]}");
        }

        if (dezenaNumeroMilhao == 1)
        {
            if (centenaNumeroMilhao > 0)
                Console.Write(" e ");

            Console.Write($"{excecao[unidadeNumeroMilhao]}");
        }

        else
        {
            if (dezenaNumeroMilhao > 1)
            {
                if (centenaNumeroMilhao > 0)
                    Console.Write(" e ");

                Console.Write($"{dezena[dezenaNumeroMilhao]}");
            }

            if (unidadeNumeroMilhao > 0)
            {
                if (centenaNumeroMilhao > 0 || dezenaNumeroMilhao > 1)
                    Console.Write(" e ");

                Console.Write($"{unidade[unidadeNumeroMilhao]}");
            }
        }

        if (milhaoNumero == 1)
            Console.Write(" milhão ");
        else
            Console.Write(" milhões ");
    }
}

if (milharNumero > 0)
{
    int centenaMilhar = milharNumero / 100;
    int dezenaMilhar = (milharNumero % 100) / 10;
    int unidadeMilhar = milharNumero % 10;

    if (milharNumero < 10)
    {
        Console.Write($"{unidade[milharNumero]} mil ");
    }

    else if (milharNumero >= 10 && milharNumero <= 19)
    {
        Console.Write($"{excecao[milharNumero - 10]} mil ");
    }

    else
    {
        if (milharNumero == 100)
        {
            Console.Write("Cem mil ");
        }

        else
        {
            if (centenaMilhar > 0)
            {
                Console.Write($"{centena[centenaMilhar]}");
            }

            if (dezenaMilhar == 1)
            {
                if (centenaMilhar > 0)
                    Console.Write(" e ");

                Console.Write($"{excecao[unidadeMilhar]}");
            }

            else
            {
                if (dezenaMilhar > 1)
                {
                    if (centenaMilhar > 0)
                        Console.Write(" e ");

                    Console.Write($"{dezena[dezenaMilhar]}");
                }

                if (unidadeMilhar > 0)
                {
                    if (centenaMilhar > 0 || dezenaMilhar > 1)
                        Console.Write(" e ");

                    Console.Write($"{unidade[unidadeMilhar]}");
                }
            }

            Console.Write(" mil ");
        }
    }
}

int centenaNumero = resto / 100;
int dezenaNumero = (resto % 100) / 10;
int unidadeNumero = resto % 10;

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