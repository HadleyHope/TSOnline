using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSOnline.Common.Interfaces.Services
{
    public interface ITSOnlineDatabaseSettings
    {
        string ConnectionString { get; set; }
    }
}
