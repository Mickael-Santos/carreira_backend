public class Biome
{
    public string Name { get; set; }
    public List<Enemie> Monsters = new List<Enemie>();
    public List<City> Cities = new List<City>();
    public Biome(string name)
    {
        Name = name;
    }
    public void AddMob(Enemie monster)
    {
        Monsters.Add(monster);
    }
    public void AddCity(City city)
    {
        Cities.Add(city);
    }

}