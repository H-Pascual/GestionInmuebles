namespace GestionInmuebles.Models.PropertyLogic;
public class TenantLog
{
    public Guid Id { get; private set; }
    public Tenant Tenant { get; set; }
    public Property Property { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal RentalPrice { get; set; }

    public TenantLog(Tenant tenant, Property property)
    {
        Id = Guid.NewGuid();
        Tenant = tenant;
        Property = property;
        StartDate = (DateTime)tenant.StartDate;
        EndDate = (DateTime)tenant.EndDate;
        RentalPrice = (decimal)property.RentalPrice;
    }
}
