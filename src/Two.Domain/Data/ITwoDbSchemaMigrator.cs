using System.Threading.Tasks;

namespace Two.Data
{
    public interface ITwoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
