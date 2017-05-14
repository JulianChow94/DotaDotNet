using DotaApiCore.MatchDetails;
using DotaApiCore.MatchDetails.Models;
using DotaApiCore.Requests;
using DotaApiUnitTests.MockData;
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
        private Mock<IHttpHandler> _httpClientMock;

        [TestInitialize]
        public void Init()
        {
            _httpClientMock = new Mock<IHttpHandler>();
        }

        [TestCleanup]
        public void Destroy() { }

        [TestMethod]
        public void GetMatchDetails_OldMatch()
        {
            _httpClientMock.Setup(s => s.SendRequest(It.IsAny<string>())).Returns(MatchDetailsServiceMockData.OldMatch);
            IMatchDetailsService service = new MatchDetailsService(_httpClientMock.Object, MockApiKey);
            MatchDetailsResult result = service.GetMatchDetails(MockMatchId).Result;

            Assert.AreEqual(result.MatchDuration, 1914);
            Assert.IsFalse(result.RadiantWin);
            Assert.IsNull(result.ErrorMessage);
        }

        [TestMethod]
        public void GetMatchDetails_NewMatch()
        {
            _httpClientMock.Setup(s => s.SendRequest(It.IsAny<string>())).Returns(MatchDetailsServiceMockData.NewMatch);
            IMatchDetailsService service = new MatchDetailsService(_httpClientMock.Object, MockApiKey);
            MatchDetailsResult result = service.GetMatchDetails(MockMatchId).Result;

            Assert.AreEqual(result.MatchDuration, 2151);
            Assert.IsFalse(result.RadiantWin);
            Assert.IsNull(result.ErrorMessage);
        }

        [TestMethod]
        public void GetMatchDetails_FailedFetch()
        {
            _httpClientMock.Setup(s => s.SendRequest(It.IsAny<string>())).Returns(MatchDetailsServiceMockData.FailedMatch);
            IMatchDetailsService service = new MatchDetailsService(_httpClientMock.Object, MockApiKey);
            MatchDetailsResult result = service.GetMatchDetails(MockMatchId).Result;

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ErrorMessage);
        }
    }
}
