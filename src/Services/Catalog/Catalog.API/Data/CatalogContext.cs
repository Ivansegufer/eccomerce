using Catalog.API.Data.Interfaces;
using Catalog.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {            
            var client = new MongoClient(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
            var database = client.GetDatabase(Environment.GetEnvironmentVariable("DATABASE_NAME"));

            Products = database.GetCollection<Product>(Environment.GetEnvironmentVariable("DATABASE_COLLECTION"));
            CatalogContextSeed.SeedData(Products);
        }

        public IMongoCollection<Product> Products { get; }
    }
}
