using sql.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql
{
    class Program
    {
        public static void Main(string[] args)
        {

            var x = Microsoft.SqlServer.Management.Smo.SmoApplication.EnumAvailableSqlServers();


            var Linst = new List<instancias>();
            foreach (System.Data.DataRow item in x.Rows)
            {
                var inst = new instancias
                {
                    Name = item[0].ToString(),
                    Server = item[1].ToString(),
                    Instance = item[2].ToString(),
                    IsClustered = item[3].ToString(),
                    Version = item[4].ToString(),
                    IsLocal = item[5].ToString(),
                };
                Linst.Add(inst);
            }
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("||Name||Server||Instance||IsClustered||Version||IsLocal||");

            foreach (var item in Linst)
            {
                Console.WriteLine(item.Server.Length);
            }
            Console.ReadLine();
        }

    }
}

