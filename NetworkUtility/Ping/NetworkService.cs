using NetworkUtility.DNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Ping
{
    public class NetworkService
    {
        IDNS _dns;
        
        public NetworkService(IDNS dns) 
        { 
            _dns = dns;
        }
        public NetworkService()
        {
        }

        public string SendPing()
        {
            bool isSuccess = true;
            if (_dns != null) 
                 isSuccess=_dns.SendDNS();
            if (isSuccess)
            {
                return "Sent Ping!";
            }
            return "Sent Sending Failed!";
        }

        public int TimeOut(int a, int b)
        {
            return a+b;
        }
        public DateTime LastPingDate()
        {
            return DateTime.Now;
        }

        public PingOptions GetPingOptions()
        {
            return new PingOptions()
            {
                DontFragment = true,
                Ttl=1
            };
        }

        public IEnumerable<PingOptions> MostRecentPings()
        {
            List<PingOptions> pingOptions = new List<PingOptions>();
            pingOptions.Add(new PingOptions
            {
                DontFragment = true,
                Ttl = 1
            });
            pingOptions.Add(new PingOptions
            {
                DontFragment = true,
                Ttl = 2
            });
            pingOptions.Add(new PingOptions
            {
                DontFragment = true,
                Ttl = 3
            });

            return pingOptions;
        }
    }
}
