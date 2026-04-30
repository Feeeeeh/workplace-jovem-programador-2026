public class Exportador()
{
    public void ExportarPdf(Pdf pdf)
    {
        pdf.exportar();
    }
    
    public void ExportarCsv(Csv csv)
    {
        csv.exportar();
    }

    public void Exportarjson(Json json)
    {
        json.exportar();
    }
    
}