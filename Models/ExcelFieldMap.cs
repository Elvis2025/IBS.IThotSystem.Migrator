namespace IBS.IThotSystem.Migrator.Models
{
    public class ExcelFieldMap
    {
        public string SqlFieldName { get; set; } = string.Empty;

        public string ExcelColumnName { get; set; } = string.Empty;

        public string DataType { get; set; } = "string";

        public bool IsRequired { get; set; }

        public bool AllowNull { get; set; }

        public string? DefaultValue { get; set; }

        public bool UseExcelColumn { get; set; } = true;
    }
}
