namespace GestionInmuebles.Models.PropertyLogic;
public enum PropertyType { Residential, Commercial }
public enum PropertyState { GoodCondition, NeedsRenovation }
public class Property
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public bool HaveIVA { get; set; }
    public DateTime PurchaseDate { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal? RentalPrice { get; set; }
    public string? Observations { get; set; }
    public int SquareMeters { get; set; }
    public bool IsRented { get; set; }
    public bool HadRenovations { get; set; }
    public PropertyType PropertyType { get; set; }
    public decimal? RenovationPrice { get; set; }
    public PropertyState PropertyState { get; set; }

    public Property(string name, string address, int squareMeters)
    {
        Id = Guid.NewGuid();
        Address = address;
        SquareMeters = squareMeters;
        Name = name;
        HaveIVA = false;
        HadRenovations = false;
    }

    public Property(string name, string address, DateTime purchaseDate, decimal purchasePrice, int squareMeters, bool? HaveIVA)
    {
        Id = Guid.NewGuid();
        Name = name;
        Address = address;
        PurchaseDate = purchaseDate;
        PurchasePrice = purchasePrice;
        SquareMeters = squareMeters;
        HaveIVA = HaveIVA | false;
        HadRenovations = false;
    }

    public void AddRenovations(decimal renovationPrice)
    {
        HadRenovations = true;
        RenovationPrice = renovationPrice;
    }

    public void AddObservation(string observation)
    {
        Observations = observation;
    }

    public void RemoveRent()
    {
        IsRented = false;
        RentalPrice = null;
    }
    public void ChangeRentalPrice(decimal rentalPrice)
    {
        IsRented = true;
        RentalPrice = rentalPrice;
    }
}