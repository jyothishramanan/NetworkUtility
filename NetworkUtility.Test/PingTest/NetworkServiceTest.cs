using FakeItEasy;
using FluentAssertions;
using FluentAssertions.Extensions;
using NetworkUtility.Ping;
using NetworkUtility.DNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NetworkUtility.Test.PingTest
{
    public class NetworkServiceTest
    {
        [Fact]
        public void NetworkService_SendPing_Ret_String()
        {
            //Arrange- Variables, class, Mock
            var dns = A.Fake<IDNS>();
            A.CallTo(() => dns.SendDNS()).Returns(true);
            var pingService = new NetworkService(dns);

            //Act
            var result = pingService.SendPing();

            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Sent Ping!");

        }

        //[Theory]
        //[InlineData(2, 3, 5)]
        //[InlineData(2, 4, 6)]
        //public void NetworkService_TimeOut_Ret_Int(int a,int b,int c)
        //{
        //    //Arrange- Variables, class, Mock
        //    var pingService = new NetworkService();

        //    //Act
        //    var result = pingService.TimeOut(a,b);

        //    //Assert
        //    result.Should().Be(c);

        //}

        //[Fact]
        //public void NetworkService_LastPingDate_Ret_DateTime()
        //{
        //    //Arrange- Variables, class, Mock
        //    var pingService = new NetworkService();

        //    //Act
        //    var result = pingService.LastPingDate();

        //    //Assert
        //    result.Should().BeAfter(1.January(2010));
        //    result.Should().BeBefore(DateTime.Today.AddDays(1));

        //}

        //[Fact]
        //public void NetworkService_GetPingOptions_Ret_PingOptions()
        //{
        //    //Arrange- Variables, class, Mock
        //    var pingService = new NetworkService();
        //    var expected = new PingOptions()
        //    {
        //        Ttl=1,
        //        DontFragment=true,
        //    };

        //    //Act
        //    var result = pingService.GetPingOptions();

        //    //Assert
        //    result.Should().BeOfType<PingOptions>();
        //    result.Should().BeEquivalentTo(expected);
        //    result.DontFragment.Should().BeTrue();

        //}

        //[Fact]
        //public void NetworkService_MostRecentPings_Ret_PingOptions()
        //{
        //    //Arrange- Variables, class, Mock
        //    var pingService = new NetworkService();
        //    List<PingOptions> expected = new List<PingOptions>();
        //    expected.Add(new PingOptions
        //    {
        //        DontFragment = true,
        //        Ttl = 1
        //    });
        //    expected.Add(new PingOptions
        //    {
        //        DontFragment = true,
        //        Ttl = 2
        //    });
        //    expected.Add(new PingOptions
        //    {
        //        DontFragment = true,
        //        Ttl = 3
        //    });

        //    //Act
        //    var result = pingService.MostRecentPings();

        //    //Assert
        //    //result.Should().BeOfType<IEnumerable<PingOptions>>();
        //    result.Should().ContainEquivalentOf(expected);
        //    result.Should().Contain(x=>x.Ttl==3);

        //}
    }
}
