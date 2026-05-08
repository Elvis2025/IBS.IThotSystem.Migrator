using IBS.IThotSystem.Migrator.Models;
using System.Globalization;
using System.Text;

namespace IBS.IThotSystem.Migrator.Services;

public class SqlGeneratorService
{
    private const int MaxRowsPerInsert = 1000;

    public string GenerateInsertSql(
        string tableName,
        List<ExcelFieldMap> fields,
        List<Dictionary<string, string?>> rows)
    {
        if (string.IsNullOrWhiteSpace(tableName))
            throw new Exception("Debe indicar el nombre de la tabla.");

        if (!fields.Any())
            throw new Exception("Debe agregar al menos un campo.");

        if (!rows.Any())
            throw new Exception("El Excel no contiene registros.");

        var sql = new StringBuilder();

        var sqlFields = string.Join(", ", fields.Select(x => $"[{x.SqlFieldName}]"));

        sql.AppendLine("SET XACT_ABORT ON;");
        sql.AppendLine("BEGIN TRANSACTION;");
        sql.AppendLine();

        for (int i = 0; i < rows.Count; i += MaxRowsPerInsert)
        {
            var batchRows = rows.Skip(i).Take(MaxRowsPerInsert).ToList();

            sql.AppendLine($"INSERT INTO [{tableName}] ({sqlFields})");
            sql.AppendLine("VALUES");

            var valuesLines = new List<string>();

            foreach (var row in batchRows)
            {
                var values = new List<string>();

                foreach (var field in fields)
                {
                    string? value = null;

                    if (field.UseExcelColumn)
                    {
                        row.TryGetValue(field.ExcelColumnName, out value);
                    }
                    else
                    {
                        value = field.DefaultValue;
                    }

                    values.Add(FormatSqlValue(value, field));
                }

                valuesLines.Add($"({string.Join(", ", values)})");
            }

            sql.AppendLine(string.Join("," + Environment.NewLine, valuesLines));
            sql.AppendLine(";");
            sql.AppendLine();
        }

        sql.AppendLine("COMMIT TRANSACTION;");

        return sql.ToString();
    }

    private string FormatSqlValue(string? value, ExcelFieldMap field)
    {
        value = value?.Trim();

        if (string.IsNullOrWhiteSpace(value))
        {
            if (field.UseExcelColumn && !string.IsNullOrWhiteSpace(field.DefaultValue))
                value = field.DefaultValue;

            else if (field.AllowNull)
                return "NULL";

            else if (field.IsRequired)
                return GetDefaultByType(field.DataType);
        }

        return field.DataType switch
        {
            "string" => $"N'{EscapeSql(value)}'",

            "int" => int.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var intValue)
                ? intValue.ToString(CultureInfo.InvariantCulture)
                : "0",

            "long" => long.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var longValue)
                ? longValue.ToString(CultureInfo.InvariantCulture)
                : "0",

            "decimal" => decimal.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var decValue)
                ? decValue.ToString(CultureInfo.InvariantCulture)
                : "0",

            "date" => DateTime.TryParse(value, out var dateValue)
                ? $"'{dateValue:yyyy-MM-dd HH:mm:ss}'"
                : "NULL",

            "bool" => ParseBool(value),

            _ => $"N'{EscapeSql(value)}'"
        };
    }

    private string GetDefaultByType(string type)
    {
        return type switch
        {
            "string" => "N''",
            "int" => "0",
            "long" => "0",
            "decimal" => "0",
            "date" => "GETDATE()",
            "bool" => "0",
            _ => "NULL"
        };
    }

    private string ParseBool(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return "0";

        value = value.Trim().ToLower();

        return value switch
        {
            "true" => "1",
            "yes" => "1",
            "si" => "1",
            "sí" => "1",
            "1" => "1",
            "activo" => "1",
            "active" => "1",

            "false" => "0",
            "no" => "0",
            "0" => "0",
            "inactivo" => "0",
            "inactive" => "0",

            _ => "0"
        };
    }

    private string EscapeSql(string? value)
    {
        return value?.Replace("'", "''") ?? "";
    }
}