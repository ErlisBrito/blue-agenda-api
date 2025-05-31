namespace blue_agenda_api.Configuration
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //var connectionString = ConnectionHelper.GetConnection(configuration);

            //services.AddDbContext<HashContext>(options =>
            //{
            //    options.UseOracle(connectionString);
            //    options.EnableSensitiveDataLogging();
            //});
        }
    }
}
