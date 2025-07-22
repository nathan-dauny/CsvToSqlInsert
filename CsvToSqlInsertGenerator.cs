using CsvToDynamicObjectLib;

namespace CsvToSqlInsert
{
    public class CsvToSqlInsertGenerator
    {
        private readonly ICsvToSqlConverter _converter;
        public CsvToSqlInsertGenerator(ICsvToSqlConverter converter)
        {
            _converter = converter;
        }
        public IEnumerable<string> Generate(string tableName, CsvFinalObject csvData, Dictionary<string, Type> columnTypes)
        {
            return _converter.GenerateSqlStatements(tableName, csvData, columnTypes);
        }
    }
}
