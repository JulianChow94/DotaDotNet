using System.IO;
using System.Net.Http;
using DotaApiCore.MatchHistory;
using DotaApiCore.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DotaApiUnitTests
{

    [TestClass()]
    public class MatchHistoryServiceTests
    {
        public string MockApiKey = "MockApiKey";

        private Mock<IHttpHandler> _httpClientMock;

        [TestInitialize]
        public void Init()
        {
           _httpClientMock = new Mock<IHttpHandler>();
            StreamReader file = File.OpenText(@"MockData/MatchHistory.json");
            HttpResponseMessage y = new HttpResponseMessage();
            string testJsonData = file.ReadToEnd();

            //_httpClientMock.Setup(x => x.GetAsync(It.IsAny<string>())).Returns(testJsonData);
        }

        [TestMethod]
        public void TestMethod1()
        {
            MatchHistoryService x = new MatchHistoryService(_httpClientMock.Object, MockApiKey);
        }
    }
}
