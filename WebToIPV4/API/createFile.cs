using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WebToIPV4.API
{
    class createFile
    {
        public static void Create(string fileName,string responseFromServer)
        {
            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine("Website(" + fileName + ") - " + responseFromServer);
            }
        }
    }
}
