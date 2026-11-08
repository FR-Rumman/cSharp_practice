namespace Extensibility
{
    class Program
    {
        static void Main(String[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
        }
    }
}