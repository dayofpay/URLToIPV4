using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
namespace WebToIPV4.API
{
    class sendRequest
    {
        public static void Send()
        {
                var websites = Console.ReadLine();
                var readfiles = File.ReadAllLines(websites);
            foreach (string x in readfiles)
            {
                try
                {
                    changeColor.Green();
                    WebRequest request = WebRequest.Create("http://ip-api.com/line/" + x + "?fields=query");
                    request.Credentials = CredentialCache.DefaultCredentials;
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    Console.WriteLine("WebSite: " + x + " IP: " + responseFromServer);
                    string fileName = @"Results.txt";
                    File.AppendAllText(@"Results.txt","Website: " + x + " IP: " + responseFromServer);
                }
                catch (Exception error)
                {
                    changeColor.Red();
                    Console.WriteLine("Oops ... We ran into error \r\n" + error.Message);
                    break;
                }
            }
        }
    }
}
