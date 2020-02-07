using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginarDatosFnSQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Models.dbCursosEntities())
            {
                List<Models.fnPaginar_Result> lst =
                    db.fnPaginar(0, 5).ToList();

                foreach (var oElement in lst)
                {
                    Console.WriteLine(oElement.estado);
                }
            }

            Console.ReadLine(); 
        }
    }
}
