using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GestorProductos
{
    /// <summary>
    /// Clase utilizada para generar un documento PDF que contiene los datos de los productos gestionados en el programa, excepto las imágenes.
    /// </summary>
    class CProductosPDF
    {
        private const float milimetro = 2.83465f; // 1 milímetro son 2.83465 puntos de pantalla.

        public string fileName = "productos.pdf";

        /// <summary>
        /// Función que recibe un DataTable y genera el Document en formato PDF que contiene los productos.
        /// </summary>
        /// <param name="table">DataTable que contiene los datos de los productos.</param>
        /// <exception cref="Exception">Exception lanzada en caso de no poder guardar el archivo .pdf en disco.</exception>
        /// <exception cref="System.Exception">Exception lanzada en caso de no poder generar el archivo.</exception>
        public void Imprimir(DataTable table)
        {
            Document document = new Document(); // Documento PDF.

            document.SetPageSize(iTextSharp.text.PageSize.A4); // Tamaño de la hoja A4.
            // document.SetPageSize(iTextSharp.text.PageSize.A4.rotate()); --> Para la página en horizontal
            document.SetMargins(10f * milimetro, // Margen derecho 10 mm ó 1 cm.
                                10f * milimetro, // Margen izquierdo 10 mm ó 1 cm.
                                30f * milimetro, // Margen superior 30 mm ó 3 cm.
                                10f * milimetro); // Margen inferior 10 mm ó 1 cm.
            try
            {

                FileStream file = new FileStream(fileName, FileMode.Create);
                // Guardamos el contenido en un fichero "productos.pdf"
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, file);

                pdfWriter.PageEvent = new HeaderFooter(); // Indicamos nuestro pie de página personalizado.
            }
            catch (Exception ex)
            {
                // En caso de no poder guardar en "productos.pdf" lanzamos excepción.
                throw new Exception("Al guardar el fichero " + fileName + ". \n\n" + ex.Message);
            }

            document.Open(); // Abrimos el documento.

            try
            {
                ModeloProducto productos = new ModeloProducto(); // Creamos el objeto productos.

                DataRow[] rows = new DataRow[table.Rows.Count];

                for (int i = 0; i < rows.Length; i++)
                {
                    rows[i] = table.Rows[i];
                }

                PdfPTable tProductos = new PdfPTable(6); // Tabla para mostrar los productos, 6 columnas

                PdfPCell celdaCabecera = new PdfPCell(); // Celda para la cabecera.
                PdfPCell celdaDerecha = new PdfPCell(); // Celda para alineación derecha.

                tProductos.WidthPercentage = 100f; // La tabla tendrá una anchura del 100% de la página

                float[] widths = new float[] { 10f, 40f, 20f, 30f, 80f, 30f };
                tProductos.SetWidths(widths);

                celdaDerecha.HorizontalAlignment = Element.ALIGN_RIGHT; // La celda derecha alineada a la derecha
                celdaDerecha.FixedHeight = 7f * milimetro; // Altura de las celdas

                celdaCabecera.HorizontalAlignment = Element.ALIGN_CENTER; // La cabecera se alinea al centro
                celdaCabecera.BackgroundColor = new BaseColor(Color.LightGray);
                celdaCabecera.FixedHeight = 7f * milimetro; // Altura de celda de 7 mm.

                celdaCabecera.Phrase = new Phrase("ID"); // Título de la celda código.
                tProductos.AddCell(celdaCabecera); // Añadimos la celda.

                celdaCabecera.Phrase = new Phrase("Nombre");
                tProductos.AddCell(celdaCabecera);

                celdaCabecera.Phrase = new Phrase("Stock");
                tProductos.AddCell(celdaCabecera);

                celdaCabecera.Phrase = new Phrase("Precio");
                tProductos.AddCell(celdaCabecera);

                celdaCabecera.Phrase = new Phrase("Descripción");
                tProductos.AddCell(celdaCabecera);

                celdaCabecera.Phrase = new Phrase("Tipo");
                tProductos.AddCell(celdaCabecera);

                tProductos.HeaderRows = 1; // La primera fila (cabecera) se repetirá en cada página

                for (int i = 0; i < rows.Count(); i++)
                {
                    celdaDerecha.Phrase = new Phrase(rows[i]["ID"].ToString()); // Código.
                    tProductos.AddCell(celdaDerecha); // No lo insertamos directamente porque lo queremos alinear a la derecha.

                    tProductos.AddCell(rows[i]["Nombre"].ToString());

                    celdaDerecha.Phrase = new Phrase(rows[i]["Stock"].ToString());
                    tProductos.AddCell(celdaDerecha);

                    celdaDerecha.Phrase = new Phrase(String.Format("{0:N2}" +" €", rows[i]["Precio"])); 
                    tProductos.AddCell(celdaDerecha);

                    tProductos.AddCell(rows[i]["Descripción"].ToString());
                    tProductos.AddCell(rows[i]["Tipo"].ToString());
                }

                document.Add(tProductos); // Añadimos la tabla al documento.
            }
            catch (Exception ex)
            {
                // En caso de error lanzamos la excepción con el error que se ha producido.
                throw new System.Exception("Al generar el archivo " + fileName + ". \n\n" + ex.Message);
            }
            finally
            {
                document.Close(); // Cerramos el documento
            }
        }
    }
    /// <summary>
    /// Clase que nos sirve para establecer las secciones de cabecera y pie de página de los documentos PDF que generemos.
    /// </summary>
    class HeaderFooter : PdfPageEventHelper
    {
        private const float milimetro = 2.83465f; // 1 milímetro equivale a 2.83465 puntos.
        public override void OnEndPage(PdfWriter writer, Document document) // Sobreescribir el método
        {
            base.OnEndPage(writer, document); //Llamar a la función sobreescrita y seguir.

            PdfPTable tCabecera = new PdfPTable(3); // Tabla para poner la información en la cabecera con 3 columnas.
            PdfPTable tPie = new PdfPTable(3); // Tabla para poner la información en el pie.

            PdfPCell celdaLogo = new PdfPCell(); // Celda para poner el logo.
            PdfPCell celdaTitulo = new PdfPCell(); // Celda para poner el título.

            PdfPCell celdaFecha = new PdfPCell(); // Celda para poner la fecha.
            PdfPCell celdaNumPagina = new PdfPCell(); // Celda para poner el número de página

            iTextSharp.text.Font fontTitulo = FontFactory.GetFont("Arial", 16f); // Fuente para utilizar en el título.
            iTextSharp.text.Font fontPie = FontFactory.GetFont("Arial", 10f); // Fuente para utilizar en el pie.

            fontTitulo.Color = new BaseColor(0, 71, 185); // Color RGB y
            fontTitulo.SetStyle(iTextSharp.text.Font.BOLD); // estilo en negrita.

            fontPie.Color = fontTitulo.Color; // Color y
            fontPie.SetStyle(iTextSharp.text.Font.NORMAL); // estilo normal.

            celdaLogo.VerticalAlignment = Element.ALIGN_MIDDLE; // Alineación vertical de la celda.
            celdaLogo.Border = 0; // Sin borde.

            celdaTitulo.VerticalAlignment = Element.ALIGN_BOTTOM;
            celdaTitulo.HorizontalAlignment = Element.ALIGN_RIGHT; // Alineación horizontal de la celda.
            celdaTitulo.Border = 0; // Sin borde en ninguna celda

            celdaFecha.HorizontalAlignment = Element.ALIGN_LEFT;
            celdaFecha.Border = 0;

            celdaNumPagina.HorizontalAlignment = Element.ALIGN_RIGHT;
            celdaNumPagina.Border = 0;

            // Ancho de la cabecera es el ancho de la página menos los márgenes laterales.
            tCabecera.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;

            tCabecera.DefaultCell.Border = 0; //Sin bordes

            string url = "https://iespacomolla.es/wp-content/uploads/2021/03/LogoWebUE.png"; // Logo del IES Poeta Paco Molla

            celdaLogo.Image = iTextSharp.text.Image.GetInstance(new Uri(url)); // Cargamos la imagen desde la URL

            celdaTitulo.Phrase = new Phrase("Listado de productos", fontTitulo); // Ponemos el título del listado y formato

            tCabecera.AddCell(celdaLogo); // Añadimos el logo a la tabla cabecera.
            tCabecera.AddCell(""); // Celda en blanco
            tCabecera.AddCell(celdaTitulo); // Celda del título

            // Escribimos la tabla cabecera
            tCabecera.WriteSelectedRows(0,                   // Desde la posición 0.
                                        -1,                  // Toda la tabla (Sólo hay una fila)
                                        document.LeftMargin, // Left -> Margen izquierda.
                                        writer.PageSize.GetTop(document.TopMargin) + (25f * milimetro), // Top -> Margen superior más 25 mm.
                                        writer.DirectContent); // Dirección.

            tPie.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            tPie.DefaultCell.Border = 0;
            celdaFecha.Phrase = new Phrase(DateTime.Now.ToString("dd/MM/yyyy"), fontPie); // Fecha de impresión.

            celdaNumPagina.Phrase = new Phrase("Página " + writer.PageNumber, fontPie); // Número de página.

            tPie.AddCell(celdaFecha);
            tPie.AddCell("");
            tPie.AddCell(celdaNumPagina);

            tPie.WriteSelectedRows(0, -1, document.LeftMargin,
                writer.PageSize.GetBottom(document.BottomMargin), writer.DirectContent);

        }
    }
}
