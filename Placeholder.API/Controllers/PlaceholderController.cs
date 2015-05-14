using System.Web.Http;
using Placeholder.Data;
using Placeholder.Storage;

namespace Placeholder.API.Controllers
{
    public class PlaceholderController : ApiController
    {
        private readonly IPlaceholderStorage _placeholderStorage;

        public PlaceholderController(IPlaceholderStorage placeholderStorage)
        {
            _placeholderStorage = placeholderStorage;
        }

        public IHttpActionResult Get()
        {
            var placeholderData = _placeholderStorage.PlaceholderData;

            return Ok(placeholderData);
        }

        public IHttpActionResult Post(PlaceholderData newData)
        {
            var success = _placeholderStorage.AddPlaceholderData(newData);

            if (!success)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
