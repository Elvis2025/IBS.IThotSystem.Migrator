using ClosedXML.Excel;

namespace IBS.IThotSystem.Migrator.Services;

public class ExcelReaderService
{
    public async Task<(List<string> Columns, List<Dictionary<string, string?>> Rows)> ReadExcelAsync(Stream stream)
    {
        using var memoryStream = new MemoryStream();
        await stream.CopyToAsync(memoryStream);
        memoryStream.Position = 0;

        using var workbook = new XLWorkbook(memoryStream);

        var worksheet = workbook.Worksheets
            .FirstOrDefault(ws => ws.RangeUsed() != null);

        if (worksheet == null)
            return (new List<string>(), new List<Dictionary<string, string?>>());

        var range = worksheet.RangeUsed();

        if (range == null)
            return (new List<string>(), new List<Dictionary<string, string?>>());

        var headerRow = range.Rows()
            .FirstOrDefault(row => row.Cells().Any(cell =>
                !string.IsNullOrWhiteSpace(cell.GetFormattedString())));

        if (headerRow == null)
            return (new List<string>(), new List<Dictionary<string, string?>>());

        var columns = new List<string>();
        var columnIndexes = new List<int>();

        foreach (var cell in headerRow.Cells())
        {
            var columnName = cell.GetFormattedString()?.Trim();

            if (!string.IsNullOrWhiteSpace(columnName))
            {
                columns.Add(columnName);
                columnIndexes.Add(cell.Address.ColumnNumber);
            }
        }

        var rows = new List<Dictionary<string, string?>>();

        foreach (var row in worksheet.RowsUsed().Where(r => r.RowNumber() > headerRow.RowNumber()))
        {
            var data = new Dictionary<string, string?>();
            var hasValue = false;

            for (int i = 0; i < columns.Count; i++)
            {
                var value = row.Cell(columnIndexes[i]).GetFormattedString()?.Trim();

                if (!string.IsNullOrWhiteSpace(value))
                    hasValue = true;

                data[columns[i]] = value;
            }

            if (hasValue)
                rows.Add(data);
        }

        return (columns, rows);
    }
}