using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.util;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MTT_Manager;
using MTT_Manager.Properties;

public static class PdfGenerator
{
    public static void PrintUsersData(List<User> userList)
    {
        // Ruta y nombre del archivo PDF que se generará
        string pdfFileName = "D:\\UsersData.pdf";
        string adminName = FireBaseControl.auth.User.Info.FirstName;
        string adminEmail = FireBaseControl.auth.User.Info.Email;

        // Crear el documento PDF en formato horizontal (paisaje)
        Document doc = new Document(PageSize.A4.Rotate());
        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfFileName, FileMode.Create));
        doc.Open();

        // Agregar información de generación al inicio del documento
        doc.Add(new Paragraph($"Fecha de generación: {DateTime.Now}"));
        doc.Add(new Paragraph($"Generado por: {adminName} ({adminEmail})"));
        doc.Add(Chunk.NEWLINE); // Salto de línea

        // Agregar texto "Tabla de jugadores" centrado
        Paragraph tablaJugadores = new Paragraph("Tabla de jugadores", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD));
        tablaJugadores.Alignment = Element.ALIGN_CENTER;
        doc.Add(tablaJugadores);
        doc.Add(Chunk.NEWLINE); // Salto de línea



        // Resto del contenido del documento
        PdfPTable table = new PdfPTable(7);
        table.WidthPercentage = 100; // Ajustar el ancho de la tabla al 100% del ancho de la página

        /// Ajustar el tamaño de fuente dentro de la tabla
        Font cellFont = new Font(Font.FontFamily.HELVETICA, 8);
        /// Ajustar el tamaño de fuente dentro de la tabla
        Font cellFontBold = new Font(Font.FontFamily.HELVETICA, 8,Font.BOLD);

        // Encabezado de la tabla con color gris claro
        PdfPCell headerCell = new PdfPCell(new Phrase("User ID", cellFontBold));
        headerCell.BackgroundColor = new BaseColor(220, 220, 220); // Color gris claro (RGB)
        table.AddCell(headerCell);

        headerCell = new PdfPCell(new Phrase("NickName", cellFontBold));
        headerCell.BackgroundColor = new BaseColor(220, 220, 220);
        table.AddCell(headerCell);

        headerCell = new PdfPCell(new Phrase("Email", cellFontBold));
        headerCell.BackgroundColor = new BaseColor(220, 220, 220);
        table.AddCell(headerCell);

        headerCell = new PdfPCell(new Phrase("Registration Date", cellFontBold));
        headerCell.BackgroundColor = new BaseColor(220, 220, 220);
        table.AddCell(headerCell);

        headerCell = new PdfPCell(new Phrase("Last Login", cellFontBold));
        headerCell.BackgroundColor = new BaseColor(220, 220, 220);
        table.AddCell(headerCell);

        headerCell = new PdfPCell(new Phrase("Last Ban", cellFontBold));
        headerCell.BackgroundColor = new BaseColor(220, 220, 220);
        table.AddCell(headerCell);

        headerCell = new PdfPCell(new Phrase("Account Active", cellFontBold));
        headerCell.BackgroundColor = new BaseColor(220, 220, 220);
        table.AddCell(headerCell);


        // Agregar filas con la información de cada usuario
        foreach (User user in userList)
        {
            table.AddCell(new PdfPCell(new Phrase(user.UserId, cellFont)));
            table.AddCell(new PdfPCell(new Phrase(user.NickName, cellFont)));
            table.AddCell(new PdfPCell(new Phrase(user.Email, cellFont)));
            table.AddCell(new PdfPCell(new Phrase(user.RegistrationDate.ToString(), cellFont)));
            table.AddCell(new PdfPCell(new Phrase(user.LastLogin.ToString(), cellFont)));
            table.AddCell(new PdfPCell(new Phrase(user.LastBan == DateTime.MinValue
                        ? "No establecido"
                        : user.LastBan.ToString(), cellFont)));
            table.AddCell(new PdfPCell(new Phrase(user.AccountActive.ToString(), cellFont)));
        }

        // Agregar la tabla al documento
        doc.Add(table);

        // Agregar información de generación en la parte central inferior del documento
        PdfContentByte cb = writer.DirectContent;

        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Resources.MTT_Logo_, System.Drawing.Imaging.ImageFormat.Png);

        // Reducir el tamaño del logo (ajusta el valor de scale)
        float scale = 0.025f;
        img.ScaleAbsolute(img.Width * scale, img.Height * scale);

        float x = (PageSize.A4.Rotate().Width - img.ScaledWidth) / 2;
        float y = PageSize.A4.Rotate().GetBottom(15); // Ajustar la posición vertical del logo según tus necesidades
        img.SetAbsolutePosition(x, y);
        cb.AddImage(img);

        BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        cb.BeginText();
        cb.SetFontAndSize(bf, 8); // Tamaño de la fuente para el texto
        float textX = PageSize.A4.Rotate().Width / 2;
        float textY = y - 10; // Ajustar la posición vertical del texto según tus necesidades
        cb.SetTextMatrix(textX, textY);
        cb.ShowTextAligned(Element.ALIGN_CENTER, "MTT Projects", textX, textY, 0);
        cb.EndText();

        // Cerrar el documento
        doc.Close();

        // Imprimir el PDF generado
        PrintPdfFile(pdfFileName);
    }

    public static void PrintPdfFile(string pdfFileName)
    {
        if (!File.Exists(pdfFileName))
        {
            MessageBox.Show("El archivo PDF no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Utilizar Process.Start para abrir el archivo PDF en el visor predeterminado
                Process.Start(pdfFileName);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al abrir el archivo PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

public class PageEventHelper : PdfPageEventHelper
{
    // Método que se llama en cada página del PDF
    public override void OnEndPage(PdfWriter writer, Document doc)
    {
        // Agregar el pie de página en cada página
        PdfContentByte cb = writer.DirectContent;

        // Agregar la imagen "MTT_Logo.png" en la esquina inferior izquierda de la página
        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Resources.MTT_Logo_, System.Drawing.Imaging.ImageFormat.Png);
        float imageWidth = 50f; // Ajusta el ancho de la imagen según tus necesidades
        float imageHeight = img.Height * imageWidth / img.Width;
        float x = 20; // Margen izquierdo de la imagen
        float y = 20; // Margen inferior de la imagen
        img.SetAbsolutePosition(x, y);
        cb.AddImage(img);

        // Agregar el texto "MTT Projects" debajo del icono
        BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        cb.BeginText();
        cb.SetFontAndSize(bf, 8); // Tamaño de la fuente para el texto
        float textX = x + imageWidth / 2;
        float textY = y - 10; // Ajusta el espacio entre la imagen y el texto según tus necesidades
        cb.SetTextMatrix(textX, textY);
        cb.ShowTextAligned(Element.ALIGN_CENTER, "MTT Projects", textX, textY, 0);
        cb.EndText();
    }
}