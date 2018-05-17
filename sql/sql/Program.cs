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
            var sizeCamps = new instanciasSize();
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
                sizeCamps.Name = inst.Name.Length > sizeCamps.Name ? inst.Name.Length : sizeCamps.Name;
                sizeCamps.Server = inst.Server.Length > sizeCamps.Server ? inst.Server.Length : sizeCamps.Server;
                sizeCamps.Instance = inst.Instance.Length > sizeCamps.Instance ? inst.Instance.Length : sizeCamps.Instance;
                sizeCamps.IsClustered = inst.IsClustered.Length > sizeCamps.IsClustered ? inst.IsClustered.Length : sizeCamps.IsClustered;
                sizeCamps.Version = inst.Version.Length > sizeCamps.Version ? inst.Version.Length : sizeCamps.Version;
                sizeCamps.IsLocal = inst.IsLocal.Length > sizeCamps.IsLocal ? inst.IsLocal.Length : sizeCamps.IsLocal;

                Linst.Add(inst);
            }
            // Console.WriteLine("---------------------------------------------------------");
            //Console.WriteLine("||Name||Server||Instance||IsClustered||Version||IsLocal||");
            string d = $"||Name{new string(' ', sizeCamps.Name)}||Server{new string(' ', sizeCamps.Server)}||Instance{new string(' ', sizeCamps.Instance)}||IsClustered{new string(' ', sizeCamps.IsClustered)}||Version{new string(' ', sizeCamps.Version)}||IsLocal{new string(' ', sizeCamps.IsLocal)}||";
            string s = $"||Name{new string(' ', sizeCamps.Name)}||Server{new string(' ', sizeCamps.Server)}";
            Console.WriteLine(s);
            foreach (var item in Linst)
            {
                item.Name = new string(' ', sizeCamps.Name - item.Name.ToString().Length) + item.Name.ToString();
                item.Server = new string(' ', sizeCamps.Server - item.Server.ToString().Length) + item.Server.ToString();
                item.Instance = new string(' ', sizeCamps.Instance - item.Instance.ToString().Length) + item.Instance.ToString();
                item.IsClustered = new string(' ', sizeCamps.IsClustered - item.IsClustered.ToString().Length) + item.IsClustered.ToString();
                item.Version = new string(' ', sizeCamps.Version - item.Version.ToString().Length) + item.Version.ToString();
                item.IsLocal = new string(' ', sizeCamps.IsLocal - item.IsLocal.ToString().Length) + item.IsLocal.ToString();

                //Console.WriteLine($"||{item.Name}||{item.Server}||{item.Instance}||{item.IsClustered}||{item.Version}||{item.IsLocal}||");
                Console.WriteLine($"||{item.Name}||{item.Server}||");

            }
            Console.ReadLine();
        }

    }
}

