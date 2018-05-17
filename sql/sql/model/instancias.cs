using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql.model
{
    class instancias
    {
        public string Name { get; set; }
        public string Server { get; set; }
        public string Instance { get; set; }
        public string IsClustered { get; set; }
        public string Version { get; set; }
        public string IsLocal { get; set; }
    }
}
