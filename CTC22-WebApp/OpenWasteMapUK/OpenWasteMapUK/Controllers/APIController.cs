using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using OpenWasteMapUK.Models;
using RestSharp;

namespace OpenWasteMapUK.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        [Route("search")]
        public async Task<IActionResult> Search(string postcode, string waste)
        {
            if (string.IsNullOrEmpty(postcode) || string.IsNullOrEmpty(waste))
            {
                return BadRequest("You must fill out postcode and waste type");
            }

            IRestClient postcodeClient = new RestClient($"https://api.postcodes.io/postcodes/{postcode}");

            IRestRequest postcodeRequest = new RestRequest();

            var postcodeResponse = await postcodeClient.ExecuteAsync(postcodeRequest);

            var postcodeData = JObject.Parse(postcodeResponse.Content);

            if (!postcodeResponse.IsSuccessful)
            {
                return BadRequest((postcodeData["error"] ?? "Unknown error occurred").Value<string>());
            }

            var councilArea = (postcodeData["result"]?["admin_district"] ?? "Unknown").Value<string>();
            var councilCode = (postcodeData["result"]?["codes"]?["admin_district"] ?? "Unknown").Value<string>();
            var country = (postcodeData["result"]?["country"] ?? "Unknown").Value<string>();


            var wasteOSMTag = TagMappings.Values.GetValueOrDefault(waste, null);

            return Ok(new
            {
                councilArea,
                councilCode,
                country,
                wasteOSMTag
            });
        }
    }
}
