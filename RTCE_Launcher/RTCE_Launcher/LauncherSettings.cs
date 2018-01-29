using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RTCE_Launcher
{
    [XmlRootAttribute("LauncherSettings")]
    public class LauncherSettings
    {
        public string ServerAddress { get; set; }
        public bool UseAltServerParameter { get; set; }
    }
}
 