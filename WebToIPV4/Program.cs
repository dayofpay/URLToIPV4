using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WebToIPV4.API;
using System.Net;
namespace WebToIPV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "URL TO IPV4 BY DAYOFPAY <3 https://github.com/dayofpay";
        RestartSoftware:
            API.changeColor.Yellow();
            Console.WriteLine("Please, insert the websites here: ");
            API.sendRequest.Send();
            goto RestartSoftware;
        }
    }
}
