using System.IO;
using Microsoft.Extensions.Configuration;

namespace PringlesDatabase.Models
{
    public class MyDBContext
    {

        static public string ConnectionString
        {
            get
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("ConnectionString.json");

                var configuration = builder.Build();
                return configuration.GetConnectionString("PringlesDatabase");
            }
        }

    }
}