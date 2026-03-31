using iText.Kernel.Pdf;
using iText.Layout.Element;
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

            var sb = new StringBuilder();

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                sb.Append(dgv.Columns[i].HeaderText);
                if (i < dgv.Columns.Count - 1)
                    sb.Append(",");
            }
            sb.AppendLine();

            // Rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    sb.Append(row.Cells[i].Value?.ToString());
                    if (i < dgv.Columns.Count - 1)
                        sb.Append(",");
                }
                sb.AppendLine();
            }

            File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

            MessageBox.Show("CSV exportado correctamente");
        }

        //PDF
        public static void ExportToPdf(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = "Export.pdf"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (var writer = new PdfWriter(sfd.FileName))
            using (var pdf = new PdfDocument(writer))
            using (var document = new iText.Layout.Document(pdf))
            {
                Table table = new Table(dgv.Columns.Count);

                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    table.AddHeaderCell(column.HeaderText);
                }

                // Rows
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value?.ToString() ?? "");
                    }
                }

                document.Add(table);
            }

            MessageBox.Show("PDF exportado correctamente");
        }
    }
}