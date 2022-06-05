namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator2 = new DbMigrator(new FileLogger("log.txt"));

            dbMigrator.Migrate();
            dbMigrator2.Migrate();
        }
    }
}
