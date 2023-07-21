namespace carvedrock.bl.principles.Solid.DependencyInversion
{
    public class DependencyInversion
    {
        public DependencyInversion()
        {
            SqlServerDatabase db = new(); 

            SalesReport monthlyReport = new(db); //si el reporte que sale lo estuviesemos sacando por ejemplo de la bd cassandra se creea la instancia de ella y listo

            monthlyReport.CreateReport(DateTime.Now.AddMonths(-1), DateTime.Now);
            monthlyReport.SaveReport();
        }
    }
}