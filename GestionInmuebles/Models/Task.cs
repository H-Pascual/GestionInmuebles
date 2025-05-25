namespace GestionInmuebles.Models;
public class Task
{
    public Guid Id { get; private set; }
    public string Description { get; set; }
    public DateTime ExpirationDate { get; set; }
    public Category Category { get; set; }
    public Priority Priority { get; set; }
}
// Añadir a las entities correspondientes