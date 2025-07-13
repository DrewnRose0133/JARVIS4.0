using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JARVIS
{
    public class AppSettings
    {
        public List<TvConfig> SamsungTvs { get; set; }
        public string AppName { get; set; }
    }

    public class TvConfig
    {
        public string Name { get; set; }
        public string IpAddress { get; set; }
    }
}
