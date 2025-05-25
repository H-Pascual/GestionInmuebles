using GestionInmuebles.Models.PropertyLogic;

namespace GestionInmuebles.Models.CompanyLogic;
public class Company
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public List<Account> AssociatedAccounts { get; set; }
    public List<Property> Properties { get; set; }
}
