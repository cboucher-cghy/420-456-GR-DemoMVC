using Exercice_Form.Data;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Exercice_Form_Seeder
{
    public class DbContextFactory //: IDesignTimeDbContextFactory<ExeDbContext>
    {
        public static ExeDbContext CreateDbContext()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ExeDbContext>();
            var connectionString = configuration.GetConnectionString("DbContext_MSSQL");
            builder.UseSqlServer(connectionString);

            return new ExeDbContext(builder.Options);
        }
    }

}
