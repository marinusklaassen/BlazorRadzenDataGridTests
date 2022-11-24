using BlazorRadzenGridTest.Server.Services;
using BlazorRadzenGridTests.BlazorApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace BasDiscogs.Server.Controllers
{
    [ApiController]
    [Route("odata/[Controller]")]
    public class ODataTestController : ControllerBase
    {
        private readonly TestDataService testDataService = new TestDataService();

        [EnableQuery(HandleNullPropagation = HandleNullPropagationOption.False)]
        public ActionResult<IQueryable<TestDataModel>> Get()
        {
            var queryable = testDataService.GetAll();
            return Ok(queryable);
        }

        [HttpPost]
        public ActionResult<TestDataModel> Post(TestDataModel testData)
        {
            var replaceItem = TestDataService.data.Where(d => d.ArtistId == testData.ArtistId).First();
            var index = TestDataService.data.IndexOf(replaceItem);
            if (index != -1)
                TestDataService.data[index] = testData;
            return StatusCode(StatusCodes.Status200OK);
        }
    }

    [ApiController]
    [Route("api/[Controller]")]
    public class ODataTestWriteController : ControllerBase
    {
        private readonly TestDataService testDataService = new TestDataService();

        [HttpPost]
        public ActionResult<TestDataModel> Post(TestDataModel testData)
        {
            var replaceItem = TestDataService.data.Where(d => d.ArtistId == testData.ArtistId).First();
            var index = TestDataService.data.IndexOf(replaceItem);
            if (index != -1)
                TestDataService.data[index] = testData;
            return StatusCode(StatusCodes.Status200OK);
        }
    }

}