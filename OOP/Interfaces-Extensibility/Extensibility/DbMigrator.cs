using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger logger;

        public DbMigrator(ILogger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            // Console.WriteLine("Migration started at {0}", DateTime.Now);
            logger.LogInfo("Migration started at " + DateTime.Now);

            //details of migrating a database

            logger.LogInfo("Migration finished at " + DateTime.Now);            
        }
    }
}
