using TSOnline.Common.Interfaces.Services;

namespace TSOnline.Models
{
    public class TSOnlineDatabaseSettings : ITSOnlineDatabaseSettings
    {
        public string ConnectionString { get; set; }
    }
}
