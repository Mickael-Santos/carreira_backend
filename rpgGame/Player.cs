public class Player
{
    public string Name { get; set; }
    public double Hp { get; set; }
    public double Damage { get; set; }
    public double Defense { get; set; }
    public double Gold { get; set; }
    public short Index_Bioma_Atual {get; set;}
    public short Index_Cidade_Atual {get; set;}
    public List<Item> Items = new List<Item>();

    public int posX = 1;
    public int posY = 2;

    public Player(string name, double hp, double damage, double defence, double gold)
    {
        Name = name;
        Hp = hp;
        Damage = damage;
        Defense = defence;
        Gold = gold;
    }

    public double Attack(string name, double enemieHp, double enemieDefense)
    {
        var attackDamage = (this.Damage - enemieDefense);

        if (attackDamage > enemieDefense)
        {
            enemieHp -= attackDamage;
            Console.WriteLine($"<< Você atacou {name} causando {attackDamage} de dano! >>");
        }
        else
        {
            Console.WriteLine($"<< Você tentou atacar {name} porém falhou! >>");
        }

        return enemieHp;
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
            if(merchant.Items[id].Quantity >= quantity)
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
            Console.WriteLine("Você não tem moedas para pagar isso!");
        }
    }

}