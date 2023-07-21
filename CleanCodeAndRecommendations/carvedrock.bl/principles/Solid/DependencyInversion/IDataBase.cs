namespace carvedrock.bl.principles.Solid.DependencyInversion
{
    public interface IDataBase
    {
        public void Connect();
        public void Insert();
        public void Update(int id);
        public void Delete();
        public object[] Select();
        public object Select(int id);
    }
}