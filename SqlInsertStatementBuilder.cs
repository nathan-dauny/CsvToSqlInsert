using CsvToDynamicObjectLib;

namespace CsvToSqlInsert
{
    public class SqlInsertStatementBuilder : ICsvToSqlConverter
    {
        public IEnumerable<string> GenerateSqlStatements(string tableName, CsvFinalObject csvData, Dictionary<string, Type> columnTypes)
        {
            foreach (var line in csvData)
            {
                var columns = string.Join(", ", line.Select(kv => kv.Key));

                var values = line.Select(kv =>
                {
                    var colName = kv.Key;
                    var value = kv.Value;
                    var type = columnTypes[colName];

                    if (value == null || string.IsNullOrEmpty(value.ToString()))
                        return "NULL";

                    if (type == typeof(string) || type == typeof(DateTime))
                        return $"'{value.ToString().Replace("'", "''")}'";

                    if (type == typeof(bool))
                        return (bool)value ? "1" : "0";

                    return value.ToString();
                });

                yield return $"INSERT INTO {tableName} ({columns}) VALUES ({string.Join(", ", values)});";
            }
        }
    }
}
