using System;
using System.IO;
using System.Linq;
using NTransmissionClient;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TransmissionClient client = new TransmissionClient("http://karamanolev.com:9091/transmission/rpc");
            client.Username = "transmission";
            client.Password = "foo";

            var bytes = File.ReadAllBytes(@"Z:\Temp\Muse - The 2nd Law - 2012.torrent");
            try
            {
                var t = client.GetTorrentFields("recently-active");
                t.Wait();
                var r = t.Result;
            }
            catch (AggregateException ex)
            {
            }
        }
    }
}
