using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstName
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var letters = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var set = new HashSet<string>(letters);

            //Console.WriteLine(names.FirstOrDefault(n => n.StartsWith()));
        }
    }
}
