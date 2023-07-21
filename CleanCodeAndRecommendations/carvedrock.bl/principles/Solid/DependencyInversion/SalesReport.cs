namespace carvedrock.bl.principles.Solid.DependencyInversion
{
    public class SalesReport
    {
        private SqlServerDatabase _database;

        public SalesReport(SqlServerDatabase database)
        {
            _database = database;
        }

        public void CreateReport(DateTime from, DateTime to)
        {
            // Create a very important report
        }

        public void SaveReport()
        {
            // Create a very important report
        }
    }
}