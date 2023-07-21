namespace carvedrock.bl.principles.Solid.DependencyInversion
{
    public class SalesReport
    {
        /// <summary>
        /// con el fin de tener multiples bases de datos de donde pueda venir dicha informacion
        /// </summary>
        private IDataBase _database;

        public SalesReport(IDataBase database)
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