using BoVoyageMVCTestNico.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestNico.Migrations
{
    public class Configuration : DbMigrationsConfiguration<BoVoyageMVCTestNicoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    }
}