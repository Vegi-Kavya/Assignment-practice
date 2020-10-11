using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Linq
    {
        static void Main(string[] args)
        {
            int[] arr = { 45, 23, 67, 90, 28, 34, 69, 31 };
            Products p = new Products();
            IList<Products> productslist = new List<Products>()
            {
                new Products(){pid=1,pname="TV" ,price=10000},
                new Products(){pid=2,pname="Watch" ,price=5000},
                new Products(){pid=3,pname="WashingMachine" ,price=15000},
                new Products(){pid=4,pname="Refrigerator" ,price=12000},
                new Products(){pid=5,pname="Invator" ,price=20000},
            };
            var pname = productslist.Where(s => s.price > 12000).Select(s => s).Where(s => s.pid > 2).Select(s => s.pname);
            var pid = productslist.Where(s => s.price<10000).Select(s => s.pid);
            var price = productslist.Where(s => s.pid>2).Select(s=>s.price);
            foreach(var name in pname)
            {
                Console.WriteLine(name);
            }
            foreach (var id in pid)
            {
                Console.WriteLine(id);
            }
            foreach (var cost in price)
            {
                Console.WriteLine(cost);
            }
            var result = from i in arr where i>23 orderby i descending select i;
            var result1 = from j in arr where j< 69 orderby j ascending select j;
            Console.WriteLine("descending order is:");
            foreach(var x in result)
            {
                Console.WriteLine(x + " ");
            }
            Console.WriteLine("ascending order is:");
            foreach (var x in result1)
            {
                Console.WriteLine(x + " ");
            }
            Console.ReadKey();
        }
    }
    class Products
    {
        private int ProductId;
        public int pid { get; set; }
        private string ProductName;
        public string pname { get; set; }
        private int ProductPrice;
        public int price { get; set; }
    }
}
