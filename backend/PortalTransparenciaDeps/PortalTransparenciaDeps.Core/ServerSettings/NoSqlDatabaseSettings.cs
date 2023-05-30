using PortalTransparenciaDeps.SharedKernel.Util;

namespace PortalTransparenciaDeps.Core.ServerSettings
{
    public class NoSqlDatabaseSettings
    {
        public string ConnectionString { get; } = AmbienteUtil.GetValue("MONGODB_CONNECTION");
        public string DatabaseName { get; } = AmbienteUtil.GetValue("MONGODB_DATABASE_NAME");
    }
}
