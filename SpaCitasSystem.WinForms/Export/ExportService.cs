using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Text;

namespace SpaCitasSystem.Shared.Export
{
    public static class ExportService
    {
        //CSV
        public static void ExportToCsv(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV (*.csv)|*.csv",
                FileName = "Export.csv"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            var columnas = dgv.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible &&
                            c.Name != "PacienteId" &&
                            c.Name != "ServicioId" &&
                            c.Name != "TerapeutaId")
                .ToList();

            var sb = new StringBuilder();

            foreach (var col in columnas)
            {
                sb.Append($"\"{col.HeaderText}\",");
            }
            sb.AppendLine();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                foreach (var col in columnas)
                {
                    var value = row.Cells[col.Name].Value?.ToString() ?? "";
                    value = value.Replace("\"", "\"\"");
                    sb.Append($"\"{value}\",");
                }

                sb.AppendLine();
            }

            File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
            MessageBox.Show("CSV exportado correctamente");
        }

        //PDF
        public static void ExportToPdf(DataGridView dgv, string titulo)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = "Reporte.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (var writer = new PdfWriter(sfd.FileName))
            using (var pdf = new PdfDocument(writer))
            using (var document = new Document(pdf))
            {
                document.SetMargins(20, 20, 20, 20);

                var imageData = ImageDataFactory.Create(
                    SpaCitasSystem.WinForms.Properties.Resources.Logo
                );

                var image = new iText.Layout.Element.Image(imageData)
                    .ScaleToFit(150, 150)
                    .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                document.Add(image);
                var boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                var tituloParrafo = new Paragraph(titulo)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(16)
                    .SetFont(boldFont);

                document.Add(tituloParrafo);
                document.Add(new Paragraph("\n"));

                var columnas = dgv.Columns
                    .Cast<DataGridViewColumn>()
                    .Where(c => c.Visible &&
                                c.Name != "PacienteId" &&
                                c.Name != "ServicioId" &&
                                c.Name != "TerapeutaId")
                    .ToList();

                Table table = new Table(columnas.Count)
                    .UseAllAvailableWidth();

                foreach (var column in columnas)
                {
                    var headerCell = new Cell()
                        .Add(new Paragraph(column.HeaderText))
                        .SetBackgroundColor(new DeviceRgb(144, 238, 144))
                        .SetFont(boldFont)
                        .SetTextAlignment(TextAlignment.CENTER);

                    table.AddHeaderCell(headerCell);
                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    foreach (var column in columnas)
                    {
                        var cellValue = row.Cells[column.Name].Value;
                        string value = "";

                        if (cellValue != null)
                        {
                            if (column.Name == "Fecha" && cellValue is DateTime fecha)
                            {
                                value = fecha.ToString("dd/MM/yyyy");
                            }
                            else if (column.Name == "Hora" && cellValue is TimeSpan hora)
                            {
                                value = DateTime.Today.Add(hora).ToString("h:mm tt");
                            }
                            else
                            {
                                value = cellValue?.ToString() ?? "";
                            }
                        }
                        table.AddCell(new Cell()
                            .Add(new Paragraph(value))
                            .SetTextAlignment(TextAlignment.CENTER));
                    }
                }

                document.Add(table);
            }
            MessageBox.Show("PDF exportado correctamente");
        }
    }
}