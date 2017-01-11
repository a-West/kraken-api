using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Kraken.Api.Controllers
{
    public class BookController : ApiController
    {
        public KrakenClient.KrakenClient krakenClient = new KrakenClient.KrakenClient();
        // GET api/values/5
        [Route("book")]
        [HttpGet]
        public HttpResponseMessage GetOrderBook(string pair)
        {
            var result = krakenClient.GetOrderBook(pair);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
