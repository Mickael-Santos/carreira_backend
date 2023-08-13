public class Caravan
{
    public string Name { get; set; }
    public double Gold { get; set; }

    public List<Item> Items = new List<Item>();

    public Caravan(string name, double gold)
    {
        Name = name;
        Gold = gold;
    }

    public void AddItemStock(Item item)
    {
        Items.Add(item);
    }

    public void BuyItemOfMerchant(Merchant merchant, short id, double price, short quantity)
    {
        var TotalPrice = quantity * price;
        if (Gold >= TotalPrice)
        {
            if (merchant.Items[id].Quantity >= quantity)
            {
                Gold -= TotalPrice;
                merchant.Gold += TotalPrice;
                merchant.Items[id].Quantity -= quantity;
                Items[id].Quantity += quantity;
            }
            else
            {
                Console.WriteLine($"O {merchant.Name} não tem essa quantidade de itens para vender!");
            }

        }
        else
        {
            Console.WriteLine($"A {Name} não tem moedas para pagar isso!");
        }
    }
}