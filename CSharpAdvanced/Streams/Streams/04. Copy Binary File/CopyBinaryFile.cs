using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            using (var reader = new FileStream("../../Image.jpg", FileMode.Open))
            {
                using (var writer = new FileStream("../../NewImage.jpg", FileMode.Create))
                {
                    while (true)
                    {
                        var buffer = new byte[4096];
                        var readBytes = reader.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
