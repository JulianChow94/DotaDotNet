using DotaApiCore.ItemDetails;
using DotaApiCore.ItemDetails.Models;
using DotaApiCore.Requests;
using DotaApiUnitTests.MockData.ItemDetailsService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DotaApiUnitTests
{
    [TestCategory("Test ItemDetailsService")]
    [TestClass()]
    public class TestItemDetailsService
    {
        private const string MockApiKey = "blah";
        private Mock<IHttpHandler> MockClient;
  

        [TestInitialize]
        public void Init()
        {
            MockClient = new Mock<IHttpHandler>();
        }

        [TestMethod]
        public void GetItemDetails_Valid()
        {
            MockClient.Setup(s => s.SendRequest(It.IsAny<string>())).Returns(ItemDetailsServiceMockData.ItemDetails);
            IItemDetailsService Service = new ItemDetailsService(MockClient.Object, MockApiKey);
            ItemDetailsResult result = Service.GetItemDetails("en-us").Result;

            Assert.AreEqual(result.Status, 200);
            Assert.IsNotNull(result.Items);
        }
    }
}
