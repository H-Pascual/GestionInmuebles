namespace GestionInmuebles.Models;
public class Account // para llevar la contabilidad
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public decimal Money { get; set; }
}
