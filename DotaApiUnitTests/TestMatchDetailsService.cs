using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using DotaApiCore.MatchDetails.Models;
using DotaApiCore.MatchDetails;
using DotaApiCore.Requests;
using DotaApiCore.SharedLib;
using DotaApiUnitTests.MockData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace DotaApiUnitTests
{
    //TODO: Write testcases for TestMatchDetailsService
    [TestCategory("Test MatchDetailsService")]
    [TestClass()]
    public class TestMatchDetailsService
    {
        private const string MockApiKey = "12345";
        private const int MockMatchId = 3154;
        private Mock<IHttpHandler> mockHandler;

        [TestInitialize]
        public void Init()
        {
            mockHandler = new Mock<IHttpHandler>();
        }

        [TestCleanup]
        public void Destroy(){}

        [TestMethod]
        public void GetMatchDetails_Pass()
        {
            mockHandler.Setup(s => s.SendRequest(It.IsAny<string>())).Returns(MatchDetailsServiceMockData.Success1);
            IMatchDetailsService service = new MatchDetailsService(mockHandler.Object, MockApiKey);
            MatchDetailsRequestResult result = service.GetMatchDetails(MockMatchId);


        }

        [TestMethod]
        public void GetMatchDetails_Fail()
        {
            mockHandler.Setup(s => s.SendRequest(It.IsAny<string>())).Returns(MatchDetailsServiceMockData.Failure1);
            IMatchDetailsService service = new MatchDetailsService(mockHandler.Object, MockApiKey);
            MatchDetailsRequestResult result = service.GetMatchDetails(MockMatchId);


        }
    }
}
