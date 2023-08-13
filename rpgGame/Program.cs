using System;
using System.Collections.Generic;


namespace rpgGame
{

    public class RpgGame
    {

        static void Main()
        {
            Start();

        }

        public static void Start()
        {
            Update();
        }
        static void Update()
        {


            // Biomas
            Biome Bioma01 = new Biome("Reino Congelado");
            Biome Bioma02 = new Biome("Ilha da Madeira");
            Biome Bioma03 = new Biome("Montanhas Rochosas");

            //Caravanas
            Caravan caravana01 = new Caravan("Caravana de Armaduras", 500);
            Caravan caravana02 = new Caravan("Caravana de Armas", 500);
            Caravan caravana03 = new Caravan("Caravana de Suprimentos", 500);
            Caravan caravana04 = new Caravan("Caravana de Matéria Prima", 500);
            //Cidades

            //Reino Congelado
            Bioma01.AddCity(new City("Narvik", Bioma01.Name));
            Bioma01.AddCity(new City("Valkyria", Bioma01.Name));
            Bioma01.AddCity(new City("Reijavik", Bioma01.Name));
            Bioma01.AddCity(new City("Tenêsys", Bioma01.Name));
            Bioma01.AddCity(new City("FrostWood", Bioma01.Name));
            //Ilha da Madeira
            Bioma02.AddCity(new City("NilfGard", Bioma02.Name));
            Bioma02.AddCity(new City("Aretusa", Bioma02.Name));
            Bioma02.AddCity(new City("Miryan", Bioma02.Name));
            Bioma02.AddCity(new City("Anystia", Bioma02.Name));
            Bioma02.AddCity(new City("Oslo", Bioma02.Name));
            //Montanhas Rochosas
            Bioma03.AddCity(new City("Amber", Bioma03.Name));
            Bioma03.AddCity(new City("Amethyst", Bioma03.Name));
            Bioma03.AddCity(new City("Diamond Garden", Bioma03.Name));
            Bioma03.AddCity(new City("Ágate", Bioma03.Name));
            Bioma03.AddCity(new City("Garnet Forest", Bioma03.Name));
            //Jogadores
            Player Jogador01 = new Player("", 100, 2, 1, 500);
            //Adição do estoque de itens do jogador

            //Armaduras
            Jogador01.AddItemStock(new Item("Capacete de Ferro", 01, 1, 0, 0.3));
            Jogador01.AddItemStock(new Item("Capacete de Prata", 02, 0, 0, 0.2));
            Jogador01.AddItemStock(new Item("Capacete de Bronze", 03, 0, 0, 0.1));
            Jogador01.AddItemStock(new Item("Capacete de Ouro Fundido", 04, 0, 0, 0.10));
            Jogador01.AddItemStock(new Item("Peitoral de Ferro", 05, 0, 0, 0.5));
            Jogador01.AddItemStock(new Item("Peitoral de Prata", 06, 0, 0, 0.4));
            Jogador01.AddItemStock(new Item("Peitoral de Bronze", 07, 0, 0, 0.3));
            Jogador01.AddItemStock(new Item("Peitoral de Ouro Fundido", 08, 0, 0, 0.25));
            Jogador01.AddItemStock(new Item("Calças de Ferro", 09, 0, 0, 0.4));
            Jogador01.AddItemStock(new Item("Calças de Prata", 10, 0, 0, 0.3));
            Jogador01.AddItemStock(new Item("Calças de Bronze", 11, 0, 0, 0.2));
            Jogador01.AddItemStock(new Item("Calças de Ouro Fundido", 12, 0, 0, 0.20));
            Jogador01.AddItemStock(new Item("Botas de Ferro", 13, 0, 0, 0.3));
            Jogador01.AddItemStock(new Item("Botas de Prata", 14, 0, 0, 0.2));
            Jogador01.AddItemStock(new Item("Botas de Bronze", 15, 0, 0, 0.1));
            Jogador01.AddItemStock(new Item("Botas de Ouro Fundido", 16, 0, 0, 0.10));
            //Armas
            Jogador01.AddItemStock(new Item("Espada de Ferro", 17, 0, 0.70, 0.3));
            Jogador01.AddItemStock(new Item("Espada de Prata", 18, 0, 0.50, 0.2));
            Jogador01.AddItemStock(new Item("Espada de Bronze", 19, 0, 0.20, 0.1));
            Jogador01.AddItemStock(new Item("Espada de Ouro Fundido", 20, 0, 0.90, 0.10));
            Jogador01.AddItemStock(new Item("Arco", 21, 0, 0.40, 0));
            Jogador01.AddItemStock(new Item("Besta", 22, 0, 0.80, 0));
            Jogador01.AddItemStock(new Item("Lança", 23, 0, 0.95, 0.30));
            //Suprimentos
            Jogador01.AddItemStock(new Item("Peixe", 24, 0, 0, 0, 0.30));
            Jogador01.AddItemStock(new Item("Pão", 25, 0, 0, 0, 0.30));
            Jogador01.AddItemStock(new Item("Carne Bovina", 26, 0, 0, 0, 0.30));
            Jogador01.AddItemStock(new Item("Verduras", 27, 0, 0, 0, 0.30));
            Jogador01.AddItemStock(new Item("Vinho", 28, 0, 0, 0, 0.30));
            Jogador01.AddItemStock(new Item("Frutas", 29, 0, 0, 0, 0.30));
            //Matéria Prima
            Jogador01.AddItemStock(new Item("Madeira", 30, 0));
            Jogador01.AddItemStock(new Item("Pedra", 31, 0));
            Jogador01.AddItemStock(new Item("Minério de Ouro", 32, 0));
            Jogador01.AddItemStock(new Item("Minério de Prata", 33, 0));
            Jogador01.AddItemStock(new Item("Minério de Bronze", 34, 0));
            Jogador01.AddItemStock(new Item("Minério de Ferro", 35, 0));
            //Adição do estoque de itens das Caravanas

            //Caravana de Armaduras
            caravana01.AddItemStock(new Item("Capacete de Ferro", 01, 1, 0, 0.3));
            caravana01.AddItemStock(new Item("Capacete de Prata", 02, 0, 0, 0.2));
            caravana01.AddItemStock(new Item("Capacete de Bronze", 03, 0, 0, 0.1));
            caravana01.AddItemStock(new Item("Capacete de Ouro Fundido", 04, 0, 0, 0.10));
            caravana01.AddItemStock(new Item("Peitoral de Ferro", 05, 0, 0, 0.5));
            caravana01.AddItemStock(new Item("Peitoral de Prata", 06, 0, 0, 0.4));
            caravana01.AddItemStock(new Item("Peitoral de Bronze", 07, 0, 0, 0.3));
            caravana01.AddItemStock(new Item("Peitoral de Ouro Fundido", 08, 0, 0, 0.25));
            caravana01.AddItemStock(new Item("Calças de Ferro", 09, 0, 0, 0.4));
            caravana01.AddItemStock(new Item("Calças de Prata", 10, 0, 0, 0.3));
            caravana01.AddItemStock(new Item("Calças de Bronze", 11, 0, 0, 0.2));
            caravana01.AddItemStock(new Item("Calças de Ouro Fundido", 12, 0, 0, 0.20));
            caravana01.AddItemStock(new Item("Botas de Ferro", 13, 0, 0, 0.3));
            caravana01.AddItemStock(new Item("Botas de Prata", 14, 0, 0, 0.2));
            caravana01.AddItemStock(new Item("Botas de Bronze", 15, 0, 0, 0.1));
            caravana01.AddItemStock(new Item("Botas de Ouro Fundido", 16, 0, 0, 0.10));
            //Caravana de Armas
            caravana02.AddItemStock(new Item("Espada de Ferro", 17, 0, 0.70, 0.3));
            caravana02.AddItemStock(new Item("Espada de Prata", 18, 0, 0.50, 0.2));
            caravana02.AddItemStock(new Item("Espada de Bronze", 19, 0, 0.20, 0.1));
            caravana02.AddItemStock(new Item("Espada de Ouro Fundido", 20, 0, 0.90, 0.10));
            caravana02.AddItemStock(new Item("Arco", 21, 0, 0.40, 0));
            caravana02.AddItemStock(new Item("Besta", 22, 0, 0.80, 0));
            caravana02.AddItemStock(new Item("Lança", 23, 0, 0.95, 0.30));
            //Caravana de Suprimentos
            caravana03.AddItemStock(new Item("Peixe", 24, 0, 0, 0, 0.30));
            caravana03.AddItemStock(new Item("Pão", 25, 0, 0, 0, 0.30));
            caravana03.AddItemStock(new Item("Carne Bovina", 26, 0, 0, 0, 0.30));
            caravana03.AddItemStock(new Item("Verduras", 27, 0, 0, 0, 0.30));
            caravana03.AddItemStock(new Item("Vinho", 28, 0, 0, 0, 0.30));
            caravana03.AddItemStock(new Item("Frutas", 29, 0, 0, 0, 0.30));
            //Caravana de Matéria Prima
            caravana04.AddItemStock(new Item("Madeira", 30, 0));
            caravana04.AddItemStock(new Item("Pedra", 31, 0));
            caravana04.AddItemStock(new Item("Minério de Ouro", 32, 0));
            caravana04.AddItemStock(new Item("Minério de Prata", 33, 0));
            caravana04.AddItemStock(new Item("Minério de Bronze", 34, 0));
            caravana04.AddItemStock(new Item("Minério de Ferro", 35, 0));

            //Inimigos

            //Reino Congelado

            Bioma01.AddMob(new Enemie("Pé Grande", 200, 3, 2));
            Bioma01.AddMob(new Enemie("Ijiraq", 150, 2, 1));
            Bioma01.AddMob(new Enemie("Nuckelavee", 300, 4, 2));
            Bioma01.AddMob(new Enemie("Mahaha", 200, 3, 2));
            Bioma01.AddMob(new Enemie("Qiqirn", 80, 3, 1));

            //Ilha da Madeira

            Bioma02.AddMob(new Enemie("Ariranha", 50, 1, 0.5));
            Bioma02.AddMob(new Enemie("Sucuri Gigante", 150, 3, 4));
            Bioma02.AddMob(new Enemie("Escorpião Tityus", 100, 4, 1));
            Bioma02.AddMob(new Enemie("Centopeia Gigante", 150, 3, 2));
            Bioma02.AddMob(new Enemie("Pope Lick", 200, 3, 4));

            //Montanhas Rochosas

            Bioma03.AddMob(new Enemie("Íbex", 100, 1, 2));
            Bioma03.AddMob(new Enemie("Leopardo", 200, 4, 5));
            Bioma03.AddMob(new Enemie("Víbora", 150, 2, 3));
            Bioma03.AddMob(new Enemie("Lobisomem", 300, 5, 4));
            Bioma03.AddMob(new Enemie("Caá Porá", 200, 3, 4));

            //Mercadores

            //Reino Congelado
            foreach (var city in Bioma01.Cities)
            {
                city.AddMerchant(new Merchant("Mercador de Armaduras", 500));
                city.AddMerchant(new Merchant("Mercador de Armas", 500));
                city.AddMerchant(new Merchant("Mercador de Suprimentos", 500));
                city.AddMerchant(new Merchant("Mercador de Matéria Prima", 500));

                foreach (var merchant in city.Merchants)
                {
                    if (merchant.Name == "Mercador de Armaduras")
                    {
                        merchant.AddItemStock(new Item("Capacete de Ferro", 01, 5, 0, 0.3));
                        merchant.AddItemStock(new Item("Capacete de Prata", 02, 10, 0, 0.2));
                        merchant.AddItemStock(new Item("Capacete de Bronze", 03, 10, 0, 0.1));
                        merchant.AddItemStock(new Item("Capacete de Ouro Fundido", 04, 3, 0, 0.10));

                        merchant.AddItemStock(new Item("Peitoral de Ferro", 05, 5, 0, 0.5));
                        merchant.AddItemStock(new Item("Peitoral de Prata", 06, 10, 0, 0.4));
                        merchant.AddItemStock(new Item("Peitoral de Bronze", 07, 10, 0, 0.3));
                        merchant.AddItemStock(new Item("Peitoral de Ouro Fundido", 08, 3, 0, 0.25));

                        merchant.AddItemStock(new Item("Calças de Ferro", 09, 5, 0, 0.4));
                        merchant.AddItemStock(new Item("Calças de Prata", 10, 10, 0, 0.3));
                        merchant.AddItemStock(new Item("Calças de Bronze", 11, 10, 0, 0.2));
                        merchant.AddItemStock(new Item("Calças de Ouro Fundido", 12, 3, 0, 0.20));

                        merchant.AddItemStock(new Item("Botas de Ferro", 13, 5, 0, 0.3));
                        merchant.AddItemStock(new Item("Botas de Prata", 14, 10, 0, 0.2));
                        merchant.AddItemStock(new Item("Botas de Bronze", 15, 10, 0, 0.1));
                        merchant.AddItemStock(new Item("Botas de Ouro Fundido", 16, 3, 0, 0.10));
                    }
                    else if (merchant.Name == "Mercador de Armas")
                    {
                        merchant.AddItemStock(new Item("Espada de Ferro", 17, 5, 0.70, 0.3));
                        merchant.AddItemStock(new Item("Espada de Prata", 18, 10, 0.50, 0.2));
                        merchant.AddItemStock(new Item("Espada de Bronze", 19, 10, 0.20, 0.1));
                        merchant.AddItemStock(new Item("Espada de Ouro Fundido", 20, 3, 0.90, 0.10));

                        merchant.AddItemStock(new Item("Arco", 21, 10, 0.40, 0));

                        merchant.AddItemStock(new Item("Besta", 22, 5, 0.80, 0));

                        merchant.AddItemStock(new Item("Lança", 23, 10, 0.95, 0.30));
                    }
                    else if (merchant.Name == "Mercador de Suprimentos")
                    {
                        merchant.AddItemStock(new Item("Peixe", 24, 20, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Pão", 25, 20, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Carne Bovina", 26, 15, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Verduras", 27, 20, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Vinho", 28, 10, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Frutas", 29, 25, 0, 0, 0.30));
                    }
                    else if (merchant.Name == "Mercador de Matéria Prima")
                    {
                        merchant.AddItemStock(new Item("Madeira", 30, 50));
                        merchant.AddItemStock(new Item("Pedra", 31, 50));
                        merchant.AddItemStock(new Item("Minério de Ouro", 32, 10));
                        merchant.AddItemStock(new Item("Minério de Prata", 33, 20));
                        merchant.AddItemStock(new Item("Minério de Bronze", 34, 15));
                        merchant.AddItemStock(new Item("Minério de Ferro", 35, 10));
                    }
                }

            }
            //Ilha da Madeira
            foreach (var city in Bioma02.Cities)
            {
                city.AddMerchant(new Merchant("Mercador de Armaduras", 500));
                city.AddMerchant(new Merchant("Mercador de Armas", 500));
                city.AddMerchant(new Merchant("Mercador de Suprimentos", 500));
                city.AddMerchant(new Merchant("Mercador de Matéria Prima", 500));

                foreach (var merchant in city.Merchants)
                {
                    if (merchant.Name == "Mercador de Armaduras")
                    {
                        merchant.AddItemStock(new Item("Capacete de Ferro", 01, 5, 0, 0.3));
                        merchant.AddItemStock(new Item("Capacete de Prata", 02, 10, 0, 0.2));
                        merchant.AddItemStock(new Item("Capacete de Bronze", 03, 10, 0, 0.1));
                        merchant.AddItemStock(new Item("Capacete de Ouro Fundido", 04, 3, 0, 0.10));

                        merchant.AddItemStock(new Item("Peitoral de Ferro", 05, 5, 0, 0.5));
                        merchant.AddItemStock(new Item("Peitoral de Prata", 06, 10, 0, 0.4));
                        merchant.AddItemStock(new Item("Peitoral de Bronze", 07, 10, 0, 0.3));
                        merchant.AddItemStock(new Item("Peitoral de Ouro Fundido", 08, 3, 0, 0.25));

                        merchant.AddItemStock(new Item("Calças de Ferro", 09, 5, 0, 0.4));
                        merchant.AddItemStock(new Item("Calças de Prata", 10, 10, 0, 0.3));
                        merchant.AddItemStock(new Item("Calças de Bronze", 11, 10, 0, 0.2));
                        merchant.AddItemStock(new Item("Calças de Ouro Fundido", 12, 3, 0, 0.20));

                        merchant.AddItemStock(new Item("Botas de Ferro", 13, 5, 0, 0.3));
                        merchant.AddItemStock(new Item("Botas de Prata", 14, 10, 0, 0.2));
                        merchant.AddItemStock(new Item("Botas de Bronze", 15, 10, 0, 0.1));
                        merchant.AddItemStock(new Item("Botas de Ouro Fundido", 16, 3, 0, 0.10));
                    }
                    else if (merchant.Name == "Mercador de Armas")
                    {
                        merchant.AddItemStock(new Item("Espada de Ferro", 17, 5, 0.70, 0.3));
                        merchant.AddItemStock(new Item("Espada de Prata", 18, 10, 0.50, 0.2));
                        merchant.AddItemStock(new Item("Espada de Bronze", 19, 10, 0.20, 0.1));
                        merchant.AddItemStock(new Item("Espada de Ouro Fundido", 20, 3, 0.90, 0.10));

                        merchant.AddItemStock(new Item("Arco", 21, 10, 0.40, 0));

                        merchant.AddItemStock(new Item("Besta", 22, 5, 0.80, 0));

                        merchant.AddItemStock(new Item("Lança", 23, 10, 0.95, 0.30));
                    }
                    else if (merchant.Name == "Mercador de Suprimentos")
                    {
                        merchant.AddItemStock(new Item("Peixe", 24, 20, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Pão", 25, 20, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Carne Bovina", 26, 15, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Verduras", 27, 20, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Vinho", 28, 10, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Frutas", 29, 25, 0, 0, 0.30));
                    }
                    else if (merchant.Name == "Mercador de Matéria Prima")
                    {
                        merchant.AddItemStock(new Item("Madeira", 30, 50));
                        merchant.AddItemStock(new Item("Pedra", 31, 50));
                        merchant.AddItemStock(new Item("Minério de Ouro", 32, 10));
                        merchant.AddItemStock(new Item("Minério de Prata", 33, 20));
                        merchant.AddItemStock(new Item("Minério de Bronze", 34, 15));
                        merchant.AddItemStock(new Item("Minério de Ferro", 35, 10));
                    }
                }
            }
            //Montanhas Rochosas
            foreach (var city in Bioma03.Cities)
            {
                city.AddMerchant(new Merchant("Mercador de Armaduras", 500));
                city.AddMerchant(new Merchant("Mercador de Armas", 500));
                city.AddMerchant(new Merchant("Mercador de Suprimentos", 500));
                city.AddMerchant(new Merchant("Mercador de Matéria Prima", 500));

                foreach (var merchant in city.Merchants)
                {
                    if (merchant.Name == "Mercador de Armaduras")
                    {
                        merchant.AddItemStock(new Item("Capacete de Ferro", 01, 5, 0, 0.3));
                        merchant.AddItemStock(new Item("Capacete de Prata", 02, 10, 0, 0.2));
                        merchant.AddItemStock(new Item("Capacete de Bronze", 03, 10, 0, 0.1));
                        merchant.AddItemStock(new Item("Capacete de Ouro Fundido", 04, 3, 0, 0.10));

                        merchant.AddItemStock(new Item("Peitoral de Ferro", 05, 5, 0, 0.5));
                        merchant.AddItemStock(new Item("Peitoral de Prata", 06, 10, 0, 0.4));
                        merchant.AddItemStock(new Item("Peitoral de Bronze", 07, 10, 0, 0.3));
                        merchant.AddItemStock(new Item("Peitoral de Ouro Fundido", 08, 3, 0, 0.25));

                        merchant.AddItemStock(new Item("Calças de Ferro", 09, 5, 0, 0.4));
                        merchant.AddItemStock(new Item("Calças de Prata", 10, 10, 0, 0.3));
                        merchant.AddItemStock(new Item("Calças de Bronze", 11, 10, 0, 0.2));
                        merchant.AddItemStock(new Item("Calças de Ouro Fundido", 12, 3, 0, 0.20));

                        merchant.AddItemStock(new Item("Botas de Ferro", 13, 5, 0, 0.3));
                        merchant.AddItemStock(new Item("Botas de Prata", 14, 10, 0, 0.2));
                        merchant.AddItemStock(new Item("Botas de Bronze", 15, 10, 0, 0.1));
                        merchant.AddItemStock(new Item("Botas de Ouro Fundido", 16, 3, 0, 0.10));
                    }
                    else if (merchant.Name == "Mercador de Armas")
                    {
                        merchant.AddItemStock(new Item("Espada de Ferro", 17, 5, 0.70, 0.3));
                        merchant.AddItemStock(new Item("Espada de Prata", 18, 10, 0.50, 0.2));
                        merchant.AddItemStock(new Item("Espada de Bronze", 19, 10, 0.20, 0.1));
                        merchant.AddItemStock(new Item("Espada de Ouro Fundido", 20, 3, 0.90, 0.10));

                        merchant.AddItemStock(new Item("Arco", 21, 10, 0.40, 0));

                        merchant.AddItemStock(new Item("Besta", 22, 5, 0.80, 0));

                        merchant.AddItemStock(new Item("Lança", 23, 10, 0.95, 0.30));
                    }
                    else if (merchant.Name == "Mercador de Suprimentos")
                    {
                        merchant.AddItemStock(new Item("Peixe", 24, 20, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Pão", 25, 20, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Carne Bovina", 26, 15, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Verduras", 27, 20, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Vinho", 28, 10, 0, 0, 0.30));
                        merchant.AddItemStock(new Item("Frutas", 29, 25, 0, 0, 0.30));
                    }
                    else if (merchant.Name == "Mercador de Matéria Prima")
                    {
                        merchant.AddItemStock(new Item("Madeira", 30, 50));
                        merchant.AddItemStock(new Item("Pedra", 31, 50));
                        merchant.AddItemStock(new Item("Minério de Ouro", 32, 10));
                        merchant.AddItemStock(new Item("Minério de Prata", 33, 20));
                        merchant.AddItemStock(new Item("Minério de Bronze", 34, 15));
                        merchant.AddItemStock(new Item("Minério de Ferro", 35, 10));
                    }
                }
            }

            //Menu
            Menu Menu = new Menu();
            //Game looping
            var LoopGame = true;

            while (LoopGame)
            {

                Menu.EscreverOpcoesPrincipais();
                var option_principal = short.Parse(Console.ReadLine());
                switch (option_principal)
                {
                    case 1:
                        {
                            Menu.EscolhaBioma(Bioma01, Bioma02, Bioma03);
                            var option_biomes = short.Parse(Console.ReadLine());
                            switch (option_biomes)
                            {
                                case 1:
                                    {
                                        Menu.EscreverOpcoesBioma(Bioma01);
                                        var option_biome = short.Parse(Console.ReadLine());
                                        switch (option_biome)
                                        {
                                            case 1: break;
                                            case 2: break;
                                            case 3: break;
                                            case 4: break;
                                            case 5:
                                                {
                                                    Menu.EscolhaCidade(Bioma01);
                                                    var option_cities = short.Parse(Console.ReadLine());
                                                    switch (option_cities)
                                                    {
                                                        case 1:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma01, 0);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                        case 2:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma01, 1);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                        case 3:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma01, 2);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                        case 4:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma01, 3);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                        case 5:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma01, 4);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                    }
                                                    break;
                                                }
                                            case 6: break;
                                            default: break;
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        Menu.EscreverOpcoesBioma(Bioma02);
                                        var option_biome = short.Parse(Console.ReadLine());
                                        switch (option_biome)
                                        {
                                            case 1: break;
                                            case 2: break;
                                            case 3: break;
                                            case 4: break;
                                            case 5:
                                                {
                                                    Menu.EscolhaCidade(Bioma02);
                                                    var option_cities = short.Parse(Console.ReadLine());
                                                    switch (option_cities)
                                                    {
                                                        case 1:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma02, 0);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                        case 2:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma02, 1);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                        case 3:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma02, 2);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                        case 4:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma02, 3);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                        case 5:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma02, 4);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                    }
                                                    break;
                                                }
                                            case 6: break;
                                            default: break;
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        Menu.EscreverOpcoesBioma(Bioma03);
                                        var option_biome = short.Parse(Console.ReadLine());
                                        switch (option_biome)
                                        {
                                            case 1: break;
                                            case 2: break;
                                            case 3: break;
                                            case 4: break;
                                            case 5:
                                                {
                                                    Menu.EscolhaCidade(Bioma03);
                                                    var option_cities = short.Parse(Console.ReadLine());
                                                    switch (option_cities)
                                                    {
                                                        case 1:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma03, 0);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                        case 2:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma03, 1);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                        case 3:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma03, 2);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                        case 4:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma03, 3);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                        case 5:
                                                            {
                                                                Menu.EscreverOpcoesCidade(Bioma03, 4);
                                                                var option_city = short.Parse(Console.ReadLine());
                                                                break;
                                                            }
                                                    }
                                                    break;
                                                }
                                            case 6: break;
                                            default: break;
                                        }
                                        break;
                                    }

                            }

                            break;
                        }
                    case 2: break;
                }
            }

        }
    }


}

