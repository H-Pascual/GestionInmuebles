namespace GestionInmuebles.Models;
public abstract class Document
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public string Route { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public string Extension { get; set; } // Mandatory? Enum { pdf, excel... 

    public void GetDocument() { } //Hacer funcional 
}
// Añadir flujos de trabajo
// Asociar con tareas de Hacienda y Locales / Compañias. EJ. Modelo 300 20/04 - Enviado Documento