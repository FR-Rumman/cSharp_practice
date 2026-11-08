using System;
using System.Collections.Generic;
using System.Text;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly Ilogger _logger;
        public DbMigrator(Ilogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started:" + DateTime.Now);
            _logger.LogInfo("Migration Finished:" + DateTime.Now);
            //details of migration of database
        }
    }
}
