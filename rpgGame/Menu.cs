public class Menu
{

    public void MenuPrincipal(bool ativado)
    {

        if (ativado)
        {
            Console.Clear();

            Console.Write(@"+===================================+
[                                   ]
[                                   ]
[                                   ]
[                                   ]
[                                   ]
[                                   ]
[                                   ]
[                                   ]
[                                   ]
[                                   ]
[                                   ]
[                                   ]
+===================================+
                ");

        }
    }

    public void EscreverOpcoesPrincipais()
    {
        MenuPrincipal(true);
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("[1 - Jogar]");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("[2 - Sair ]");
        Console.SetCursorPosition(3, 6);
        Console.Write("Opção:");
        Console.CursorVisible = false;
        Console.SetCursorPosition(10, 6);
    }

    public void EscolhaBioma(Biome bioma01, Biome bioma02, Biome bioma03)
    {
        MenuPrincipal(true);
        Console.SetCursorPosition(3, 2);
        Console.WriteLine($"1 - <<{bioma01.Name}>>");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine($"2 - <<{bioma02.Name}>>");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine($"3 - <<{bioma03.Name}>>");
        Console.SetCursorPosition(3, 8);
        Console.Write("Opção:");
        Console.CursorVisible = false;
        Console.SetCursorPosition(10, 8);

    }
    public void EscreverOpcoesBioma(Biome bioma)
    {
        MenuPrincipal(true);
        Console.SetCursorPosition(3, 1);
        Console.WriteLine($"Bioma atual: {bioma.Name}");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("[1 - Explorar]");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("[2 - Cortar Madeira ]");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("[3 - Caçar ]");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("[4 - Minerar ]");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("[5 - Viajar ]");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine("[6 - Acampar ]");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("[7 - Menu ]");
        Console.SetCursorPosition(3, 11);
        Console.Write("Opção:");
        Console.CursorVisible = false;
        Console.SetCursorPosition(10, 11);

    }
    public void EscolhaCidade(Biome bioma)
    {
        MenuPrincipal(true);
        Console.SetCursorPosition(3, 2);
        Console.WriteLine($"1 - <<{bioma.Cities[0].Name}>>");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine($"2 - <<{bioma.Cities[1].Name}>>");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine($"3 - <<{bioma.Cities[2].Name}>>");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine($"3 - <<{bioma.Cities[3].Name}>>");
        Console.SetCursorPosition(3, 10);
        Console.WriteLine($"3 - <<{bioma.Cities[4].Name}>>");
        Console.SetCursorPosition(3, 12);
        Console.Write("Opção:");
        Console.CursorVisible = false;
        Console.SetCursorPosition(10, 12);

    }
    public void EscreverOpcoesCidade(Biome bioma, int index)
    {
        MenuPrincipal(true);
        Console.SetCursorPosition(3, 1);
        Console.WriteLine($"Cidade atual: {bioma.Cities[index].Name}");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("[1 - Pousar]");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("[2 - Explorar ]");
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("[3 - Roubar ]");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("[4 - Mercado ]");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("[5 - Sair ]");
        
        Console.SetCursorPosition(3, 9);
        Console.Write("Opção:");
        Console.CursorVisible = false;
        Console.SetCursorPosition(10, 9);

    }

    public void EscreverOpcoesMercado()
    {
        MenuPrincipal(true);
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("[1 - Jogar]");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("[2 - Sair ]");
        Console.SetCursorPosition(3, 6);
        Console.Write("Opção:");
        Console.CursorVisible = false;
        Console.SetCursorPosition(3, 7);
        var option = short.Parse(Console.ReadLine());

    }

}