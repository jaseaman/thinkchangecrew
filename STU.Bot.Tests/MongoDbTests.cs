using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using STU.Bot.Model;
using STU.Bot.Repository;
using STU.Shared.Repository;

namespace STU.Bot.Tests
{
    [TestClass]
    public class MongoDbTests
    {
        public static string MongoDbConnectionString = "mongodb://utsstu:dKgwyxIXeCT3rB3igdrgqIFDFm75FqOfua8NhhxSopj8oWEhUIjFn4cPhOCljdFC6RfN8zjTkOrBhItBGHTqrQ==@utsstu.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
        public static string DatabaseName = "STU";

        [TestMethod]
        public void TestGet()
        {
            var client = new MongoClient(MongoDbConnectionString);         


            IRepository<STUResponse> repo = new MongoDbRepository<STUResponse>(client, DatabaseName);
            List<STUResponse> resp = repo.All(p => p.IntentType == "HowIsSTU").ToList();
        }
    }
}
