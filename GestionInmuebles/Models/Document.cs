namespace GestionInmuebles.Models;
public class Document
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public string Route { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
}
// Añadir flujos de trabajo
// Asociar con tareas de Hacienda y Locales / Compañias. EJ. Modelo 300 20/04 - Enviado Documento