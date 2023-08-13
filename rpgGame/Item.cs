public class Item
{
    public string Name { get; set; }

    public short Id { get; set; }
    public short Quantity { get; set; }
    public double DamageBonus { get; set; }

    public double DefenseBonus { get; set; }

    public double FoodBonus { get; set; }

    public Item(string name, short id, short quantity, double damagebonus = 0, double defensebonus = 0, double foodbonus = 0)
    {
        Name = name;
        Id = id;
        Quantity = quantity;
        DamageBonus = damagebonus;
        DefenseBonus = defensebonus;
    }

}
