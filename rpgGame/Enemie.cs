public class Enemie
{
    public string Name { get; set; }
    public double Hp { get; set; }
    public double Damage { get; set; }
    public double Defense { get; set; }

    public Enemie(string name, double hp, double damage, double defence)
    {
        Name = name;
        Hp = hp;
        Damage = damage;
        Defense = defence;
    }

    public double Attack(double enemieHp, double enemieDefense)
    {
        var attackDamage = (this.Damage - enemieDefense);

        if (attackDamage > enemieDefense)
        {
            enemieHp -= attackDamage;
            Console.WriteLine($"<< {this.Name} te atacou lhe causando {attackDamage} de dano! >>");
        }
        else
        {
            Console.WriteLine($"<< {this.Name} tentou te atacar porém falhou! >>");
        }

        return enemieHp;
    }
}