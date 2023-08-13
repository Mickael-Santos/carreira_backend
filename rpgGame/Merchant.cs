

public class Merchant
{
    public string Name { get; set; }
    public double Gold { get; set; }
    public List<Item> Items = new List<Item>();
    public Merchant(string name, double gold)
    {
        Name = name;
        Gold = gold;
    }

    public void AddItemStock(Item item)
    {
        Items.Add(item);
    }

    public void BuyItemOfPlayer(Player player, short id, double price, short quantity)
    {
        var TotalPrice = quantity * price;
        if (Gold >= TotalPrice)
        {
            if (player.Items[id].Quantity >= quantity)
            {
                Gold -= TotalPrice;
                player.Gold += TotalPrice;
                Console.WriteLine($"O {Name} te pagou {TotalPrice} pelos {quantity} Capacete de Ferro!");
                player.Items[id].Quantity -= quantity;
                Items[id].Quantity += quantity;
                Console.WriteLine($"Você entregou {quantity} de Capacete de Ferro ao {Name}!");
            }
            else
            {
                Console.WriteLine("Você não tem essa quantidade de itens para vender!");
            }

        }
        else
        {
            Console.WriteLine("O mercador não tem moedas para pagar isso!");
        }
    }

    public void BuyItemOfCaravan(Caravan caravan, short id, double price, short quantity)
    {
        var TotalPrice = quantity * price;
        if (Gold >= TotalPrice)
        {
            if (caravan.Items[id].Quantity >= quantity)
            {
                Gold -= TotalPrice;
                caravan.Gold += TotalPrice;
                Console.WriteLine($"O {Name} pagou a {caravan.Name}, {TotalPrice} moedas pelos {quantity} Capacete de Ferro!");
                caravan.Items[id].Quantity -= quantity;
                Items[id].Quantity += quantity;
                Console.WriteLine($"A {caravan.Name} entregou {quantity} de Capacete de Ferro ao {Name}!");
            }
            else
            {
                Console.WriteLine($"A {caravan.Name} não tem essa quantidade de itens para vender!");
            }

        }
        else
        {
            Console.WriteLine($"O {Name} não tem moedas para pagar isso!");
        }
    }
}