using DotaApiCore.MatchDetails.Models;
using DotaApiCore.MatchDetails;
using DotaApiCore.Requests;
using DotaApiUnitTests.MockData;
using DotaApiUnitTests.MockData.MatchHistoryService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace DotaApiUnitTests
{
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
        public void GetMatchDetails_OldMatch()
        {
            mockHandler.Setup(s => s.SendRequest(It.IsAny<string>())).Returns(MatchDetailsServiceMockData.OldMatch);
            IMatchDetailsService service = new MatchDetailsService(mockHandler.Object, MockApiKey);
            MatchDetailsResult result = service.GetMatchDetails(MockMatchId).Result;

            Assert.AreEqual(result.MatchDuration, 1914);
            Assert.IsFalse(result.RadiantWin);
            Assert.IsNull(result.ErrorMessage);
        }

        [TestMethod]
        public void GetMatchDetails_NewMatch()
        {
            mockHandler.Setup(s => s.SendRequest(It.IsAny<string>())).Returns(MatchDetailsServiceMockData.NewMatch);
            IMatchDetailsService service = new MatchDetailsService(mockHandler.Object, MockApiKey);
            MatchDetailsResult result = service.GetMatchDetails(MockMatchId).Result;

            Assert.AreEqual(result.MatchDuration, 2151);
            Assert.IsFalse(result.RadiantWin);
            Assert.IsNull(result.ErrorMessage);
        }

        [TestMethod]
        public void GetMatchDetails_FailedFetch()
        {
            mockHandler.Setup(s => s.SendRequest(It.IsAny<string>())).Returns(MatchDetailsServiceMockData.FailedMatch);
            IMatchDetailsService service = new MatchDetailsService(mockHandler.Object, MockApiKey);
            MatchDetailsResult result = service.GetMatchDetails(MockMatchId).Result;

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ErrorMessage);
        }
    }
}
