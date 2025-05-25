namespace GestionInmuebles.Models;
public enum TenantType { Particular, Company }
public class Tenant
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public Property Property { get; set; }
    public LeaseContract LeaseContract { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public TenantType Type { get; set; }
    public string? Email { get; set; }
    public string? Number { get; set; }
    public string? Address { get; set; }

    public Tenant(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }

    public Tenant(string name, Property property, DateTime startDate)
    {
        Id = Guid.NewGuid();
        Name = name;
        Property = property;
        StartDate = startDate;
    }

    public void SetContantInfo(string? email, string? number, string? address)
    {
        Email = email;
        Number = number;
        Address = address;
    }

    public (string? Email, string? Number, string? Address) GetContactInfo()
    {
        return (Email, Number, Address);
    }

    public void StartRent(DateTime startDate)
    {
        if (StartDate != null) throw new InvalidOperationException("Ya existe una fecha de inicio para este inquilino");
        StartDate = startDate;
    }

    public void EndRent(DateTime endDate)
    {
        if (EndDate != null) throw new InvalidOperationException("Ya existe una fecha de fin para este inquilino");
        EndDate = endDate
    }
}
