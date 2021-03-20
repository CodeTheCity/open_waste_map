using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
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
                return BadRequest(postcodeData["error"].Value<string>());
            }

            var councilArea = postcodeData["result"]["admin_district"].Value<string>();

            var wasteOSMTag = TagMappings.Values.GetValueOrDefault(waste, null);

            return Ok(new
            {
                councilArea,
                wasteOSMTag
            });
        }
    }
}
