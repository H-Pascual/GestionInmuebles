namespace GestionInmuebles.Models.CompanyLogic;
public class Account // para llevar la contabilidad
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public decimal Money { get; set; }

    public Account(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
        Money = 0;
    }

    public Account(string name, decimal money)
    {
        Id = Guid.NewGuid();
        Name = name;
        Money = money;
    }
}
