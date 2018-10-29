
using ListApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ListApi.DB
{
    public class DataBase : DbContext 
    {
        public DataBase(): base("Data Source=N-SOLGI-7;Initial Catalog=Service;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False") 
    {
            Database.SetInitializer<DataBase>(new DropCreateDatabaseIfModelChanges<DataBase>());

        }
        public DbSet<InitializeModel> InitializeList { get; set; }
        
    }
}