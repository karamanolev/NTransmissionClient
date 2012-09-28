using System;
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
            var stats = client.GetSessionStatistics();
            stats.Wait();
            Console.WriteLine(stats.Result.TorrentCount);
        }
    }
}
