using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql.model
{
    public class instanciasSize
    {
        public int Name { get; set; }
        public int Server { get; set; }
        public int Instance { get; set; }
        public int IsClustered { get; set; }
        public int Version { get; set; }
        public int IsLocal { get; set; }
    }
}
