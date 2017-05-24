using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var picturesCount = int.Parse(Console.ReadLine());
            var filterSeconds = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var uploadSeconds = int.Parse(Console.ReadLine());

            var goodPictures = Math.Ceiling(picturesCount * filterFactor / 100d);
            var totalSeconds = (int)(picturesCount * filterSeconds + goodPictures * uploadSeconds);

            TimeSpan totalTime = new TimeSpan(0, 0, 0, totalSeconds);
            Console.WriteLine(totalTime.ToString("d\\:hh\\:mm\\:ss"));
        }
    }
}
