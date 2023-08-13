public class City
{
    public string Name { get; set; }
    public string NameOfBiome { get; set; }

    public List<Merchant> Merchants = new List<Merchant>();

    public City(string name, string nameofbiome)
    {
        Name = name;
        NameOfBiome = nameofbiome;
    }

    public void AddMerchant(Merchant merchant)
    {
        Merchants.Add(merchant);
    }
}