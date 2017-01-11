using Jayrock.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Kraken.Api.Controllers
{
    [RoutePrefix("currency")]
    public class CurrencyController : ApiController
    {
        public KrakenClient.KrakenClient krakenClient = new KrakenClient.KrakenClient();
 
        [HttpGet]
        public HttpResponseMessage GetValues(List<string> pairs)
        {
            var result = pairs != null && pairs.Any() ? krakenClient.GetAssetPairs(pairs) : krakenClient.GetActiveAssets();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
