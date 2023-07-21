﻿namespace carvedrock.bl.principles.Solid.DependencyInversion
{
    public class SqlServerDatabase : IDataBase
    {
        // Some fields

        public void Connect()
        {
            // Do some work
        }

        public void Insert()
        {
            // Do some work
        }

        public void Update(int id)
        {
            // Do some work
        }

        public void Delete()
        {
            // Do some work
        }

        public object[] Select()
        {
            // Do some work
            return null;
        }

        public object Select(int id)
        {
            // Do some work
            return null;
        }
    }
}