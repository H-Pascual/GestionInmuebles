namespace GestionInmuebles.Models;
public class Company
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public List<Account> AssociatedAccounts { get; set; }

}
