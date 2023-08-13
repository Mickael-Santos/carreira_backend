using System;
using System.Threading;


namespace FarmTycon
{
    class Program
    {
        public static void Main(string[] args)
        {
            GameSettingsStart();
        }

        static void GameSettingsStart()
        {
            var farm = new Farm();
            farm.Info();
            farm.Menu();

        }

    }

    class Farm
    {
        //Farm+++++++++++++++++++++++++++++//
        public int Seeds;
        public int Seeds_planted;
        public int Ready_seeds;
        //public int Harvested;
        public int grain_warehouse;
        private int Production_bonus;
        private int cash;

        //market+++++++++++++++++++++++++++//
        public string[] Buyers = { "Cooperativa", "Indústria de óleo", "Fabrica de ração animal", "Refinaria de Biodiesel" };
        public int[] Buyers_grains = { 0, 0, 0, 0 };
        public int[] Buyers_prices = { 0, 0, 0, 0 };

        public int percent = 15;

        public Farm()
        {
            cash = 500;
            Seeds = 10;
            Seeds_planted = 0;
            Ready_seeds = 0;
            //Harvested = 0;
            Production_bonus = 2;
            grain_warehouse = 0;
        }

        public void Info()
        {
            Console.WriteLine("<<Você recebeu por herança uma fazenda de seu tio,\n agora você deve cuidar dela,\n gerindo da melhor forma suas econômias>>");
            Thread.Sleep(5000);
        }
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Carregando . . .");
            Price_readjustment();
            Plantation();
            Console.Clear();
            Console.WriteLine($@"
+===========★[̲̅$̲̅(̲̅∞)̲̅$̲̅]★===========+
R$:{cash},00
+===========★[̲̅$̲̅(̲̅∞)̲̅$̲̅]★===========+
            ");

            Console.WriteLine("<<Oque deseja fazer?>>");
            Console.WriteLine("[1] - Plantar\n[2] - Colher\n[3] - Armazem\n[4] - Vender grãos");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Plant(); break;
                case 2: Harvest(); break;
                case 3: ViewGrains(); break;
                case 4: SellMenu(); break;
                default:
                    Console.WriteLine("Opção inválida!");
                    Thread.Sleep(1000);
                    Menu();
                    break;
            }

        }
        public void Plant()
        {
            Console.WriteLine("Quantas sementes deseja plantar?");
            int seeds = int.Parse(Console.ReadLine());

            if (Seeds >= seeds)
            {
                Seeds -= seeds;
                int seeds_planted_now = seeds;
                Seeds_planted += seeds;
                Console.WriteLine("Foram plantados em seu campo {0} sementes!", seeds_planted_now);
                Thread.Sleep(1700);
            }
            else
            {
                Console.WriteLine("Você não tem sementes o suficiente!\n[[ Sementes: {0} ]]", Seeds);
                Thread.Sleep(1700);
            }
            Menu();
        }

        public void Plantation()
        {
            if (Seeds_planted > 0)
            {
                Seeds_planted -= 1;
                Ready_seeds += Production_bonus;
                Console.WriteLine($"A plantação está crescendo e há {Ready_seeds} sementes prontas para colheita!");
            }
            Thread.Sleep(1000);
        }

        public void Harvest()
        {
            if (Ready_seeds > 0)
            {
                Console.Clear();
                Console.WriteLine("Colhendo . . .");
                Thread.Sleep(2000);
                grain_warehouse += Ready_seeds;
                Ready_seeds = 0;
                Console.WriteLine("As sementes prontas foram colhidas, não resta mais nada para colher!");
                Console.WriteLine($"Armazém [ {grain_warehouse} ]");
                Thread.Sleep(1700);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Não há sementes prontas para colheita!");
                Console.WriteLine($"Sementes prontas [ {Ready_seeds} ]");
                Thread.Sleep(1700);
            }
            Menu();
        }

        public void ViewGrains()
        {
            Console.Clear();
            do
            {
                Console.Clear();
                var view = $@"
    _____________________________            
      Grãos : {grain_warehouse} 
    |___________________________|
                ";
                Console.WriteLine(view);
                Console.WriteLine("<< ESC para sair >>");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Menu();
        }

        public void Setcash(int amount)
        {
            cash += amount;
        }

        public void SellMenu()
        {
            Console.WriteLine("<< Escolha para quem deseja vender >>");
            Console.WriteLine("[0] - Cooperativa");
            Console.WriteLine("[1] - Indústria de óleo");
            Console.WriteLine("[2] - Fabrica de ração animal");
            Console.WriteLine("[3] - Refinaria de Biodiesel");

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:
                    {
                        Console.WriteLine("Informe a quantia da venda:");
                        var quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Confirma a venda de {quantity} grãos para a Cooperativa?");
                        Console.WriteLine("[1] - Sim\n [2] - Não");
                        var option_confirm = int.Parse(Console.ReadLine());
                        if (option_confirm == 1)
                        {
                            Sell(quantity, 0);

                        }
                        else
                        {

                            SellMenu();
                        }
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Informe a quantia da venda:");
                        var quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Confirma a venda de {quantity} grãos para a Indústria de óleo?");
                        var option_confirm = short.Parse(Console.ReadLine());
                        if (option_confirm == 1)
                        {
                            Sell(quantity, 1);
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Informe a quantia da venda:");
                        var quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Confirma a venda de {quantity} grãos para a Fabrica de ração animal?");
                        var option_confirm = short.Parse(Console.ReadLine());
                        if (option_confirm == 1)
                        {
                            Sell(quantity, 2);
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Informe a quantia da venda:");
                        var quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Confirma a venda de {quantity} grãos para a Refinaria de Biodiesel?");
                        var option_confirm = short.Parse(Console.ReadLine());
                        if (option_confirm == 1)
                        {
                            Sell(quantity, 3);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opção Inválida");
                        Thread.Sleep(1500);
                        Menu();
                        break;
                    }
            }
        }

        public void Sell(int quantity, int buyercode)
        {

            Console.Clear();
            if (grain_warehouse > quantity)
            {
                grain_warehouse -= quantity;
                Console.WriteLine($"Uma quantidade de {quantity} grãos foi enviada a {Buyers[buyercode]}");
                Thread.Sleep(1500);
                Buyers[buyercode] += quantity;
                Console.WriteLine($"{Buyers[buyercode]} recebeu quantidade de {quantity} grãos em seu armazém");
                Thread.Sleep(1500);
                Setcash(Buyers_prices[buyercode] * quantity);
                Console.WriteLine($"O {Buyers[buyercode]} pagou uma quantia pelo produto vendido!");
                Thread.Sleep(1500);
                Menu();
            }
            else
            {
                Console.WriteLine("Não há graõs suficientes em seu armazém!");
                Console.WriteLine($@"
+============+
Grãos: {grain_warehouse}
+============+                
                ");
                Thread.Sleep(1500);
                Menu();
            }
        }

        public void Price_readjustment()
        {

            for (int buyer_index = 0; buyer_index < 4; buyer_index++)
            {
                if (Buyers_grains[buyer_index] <= 10)
                {
                    Buyers_prices[buyer_index] += percent;
                    Console.WriteLine($"O comprador {Buyers[buyer_index]} aumentou sua oferta para R$ {Buyers_prices[buyer_index]} o grão!");
                    Thread.Sleep(1500);
                }
                else
                {
                    Buyers_prices[buyer_index] -= percent;
                    Console.WriteLine($"O comprador {Buyers[buyer_index]} reduziu sua oferta para R$ {Buyers_prices[buyer_index]} o grão!");
                    Thread.Sleep(1500);
                }



            }
        }
    }


}



