﻿using Creational.AbstractFactory.Interfaces;

namespace Creational.AbstractFactory.Classes
{
    public class MongoDbContext : IDataBaseContext
    {
        public MongoDbContext(string connectionString, int timeOut)
        {
            ConnectionString = connectionString;
            TimeOut = timeOut;
        }

        private string ConnectionString { get; }
        private int TimeOut { get; }

        public string GetConnectionString()
        {
            return ConnectionString;
        }

        public int GetTimeOut()
        {
            return TimeOut;
        }
    }
}