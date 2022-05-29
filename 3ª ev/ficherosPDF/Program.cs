using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ficherosPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            FileStream file = new FileStream("Datos.pdf", FileMode.Create);
            PdfWriter.GetInstance(doc, file);

            doc.Open();

            Font f = FontFactory.GetFont("Arial", 20, BaseColor.CYAN);

            Chunk c = new Chunk("Hola que tal");

            Chunk c1 = new Chunk("Pepe");

            Paragraph p = new Paragraph("Lorem fistrum dolor sed ese que llega a wan no puedor. Va usté muy cargadoo a wan está la cosa muy malar consectetur te voy a borrar el cerito. Aliquip al ataquerl me cago en tus muelas apetecan no te digo trigo por no llamarte Rodrigor. Incididunt qui no te digo trigo por no llamarte Rodrigor a gramenawer veniam dolore ahorarr et sit amet velit. Dolore te voy a borrar el cerito ese que llega incididunt esse qui diodenoo tiene musho peligro.", f);
            
            p.SpacingAfter = 20f;
            p.FirstLineIndent = 30f;
            doc.Add(p);

            p = new Paragraph("Va usté muy cargadoo a wan está la cosa muy malar consectetur te voy a borrar el cerito. Aliquip al ataquerl me cago en tus muelas apetecan no te digo trigo por no llamarte Rodrigor. Incididunt qui no te digo trigo por no llamarte Rodrigor a gramenawer veniam dolore ahorarr et sit amet velit. Dolore te voy a borrar el cerito ese que llega incididunt esse qui diodenoo tiene musho peligro.");
            doc.Add(p);


            PdfPTable tabla = new PdfPTable(4);
            PdfPCell cell = new PdfPCell(new Paragraph("Hola", f));

            cell.HorizontalAlignment = 1;
            cell.Colspan = 4;
            tabla.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Adios", f));
            tabla.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Adios", f));
            tabla.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Pepe", f));
            tabla.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Joselu", f));
            tabla.AddCell(cell);

            doc.Add(tabla);
            doc.Close();

            string json = "{\"nombre\": \"Pepe\", \"apellido\": \"asd\", \"provincia\": \"Alicante\"}";
            Console.WriteLine(json);

        }
    }
}
