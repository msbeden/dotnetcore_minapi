using minimumApi.Models;
using Microsoft.EntityFrameworkCore;

namespace minimumApi.Configuration
{
    //Veritabanı başlatıcısı
    public class DBInitializer
    {
        public static void Initialize(string connectionString)
        {
            using (minimumApiDbContext context = new minimumApiDbContext(connectionString))
            {
                context.Database.Migrate();
            }
        }
    }
}
