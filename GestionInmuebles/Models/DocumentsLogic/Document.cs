namespace GestionInmuebles.Models.DocumentsLogic;

public enum ExtensionType
{
    PDF,
    DOC,
    DOCX,
    XLS,
    XLSX,
    PPT,
    PPTX,
    TXT,
    ODT,
    CSV,
    XML,
}

public abstract class Document
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public string Route { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ExtensionType Extension { get; set; }

    public void GetDocument() {
    //Extension.ToLower();
    } //Hacer funcional 
}
// Añadir flujos de trabajo
// Asociar con tareas de Hacienda y Locales / Compañias. EJ. Modelo 300 20/04 - Enviado Documento