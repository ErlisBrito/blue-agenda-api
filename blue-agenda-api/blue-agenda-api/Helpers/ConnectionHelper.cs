using System.Text;

namespace blue_agenda_api.Helpers
{
    public class ConnectionHelper
    {
        public static string GetConnection(IConfiguration configuration)
        {
            return configuration.GetConnectionString("DataBase");
        }
    }
}
