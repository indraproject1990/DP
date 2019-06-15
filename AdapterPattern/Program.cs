using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IExport printToWord = new ToWord();
            printToWord.Save();

            IExport printToImage = new ToImage();
            printToImage.Save();

            Console.ReadKey();
        }
    }
}
