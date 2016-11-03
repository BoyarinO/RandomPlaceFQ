using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace RandomPlaceFQ.Models
{
    public class Request
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public int Radius { get; set; }
        
        public int Price { get; set; }
        public string Query { get; set; }

        private const string client_id = "RHZ3UHVB4DJHUFAI3ZTUDJJ20IONR4PNRL21EM0UACMSTR3Z";
        private const string client_secret="R3CV4C3GQ2UOA11535GUCD3KSCKSYILZUS51THX2JV1XIXDQ";



        public Request()
        { }
        

        public static string SendRequest(string request)
        {
            Request req =
            new Request
            {
                Latitude = 50.457613,
                Longitude = 30.427461,
                Radius = 2500,
                Query="Beer"
            };

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            string response;
            using (var client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                response = client.DownloadString(request);
            }
            return response;
        }

    }
}