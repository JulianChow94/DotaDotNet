using DotaApiCore.HeroDetails;
using DotaApiCore.Requests;
using DotaApiUnitTests.MockData.HeroDetailsService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Net;

namespace DotaApiUnitTests
{
    [TestCategory("Test HeroDetailsService")]
    [TestClass()]
    public class TestHeroDetailsService
    {
        private const string MockApiKey = "MockApiKey";
        private Mock<IHttpHandler> _httpClientMock;
        private HeroDetailsService _service;

        [TestInitialize]
        public void Init()
        {
            _httpClientMock = new Mock<IHttpHandler>();
            _service = new HeroDetailsService(_httpClientMock.Object, MockApiKey);
        }

        [TestMethod]
        public void GetAllHeroDetails_ValidRequest_MapsResponseCorrectly()
        {
            _httpClientMock.Setup(client => client.SendRequest(It.IsAny<string>()))
                .Returns(HeroDetailsServiceMockData.GenericSuccess);

            var response = _service.GetHeroDetails();
            Assert.AreEqual(response.Result.Status, (int)HttpStatusCode.OK);
            Assert.IsNotNull(response.Result.Heroes);
            Assert.AreEqual(response.Result.Heroes.Count, 113);
            Assert.AreEqual(response.Result.TotalHeroes, 113);
            Assert.IsTrue(true);
        }
    }
}
