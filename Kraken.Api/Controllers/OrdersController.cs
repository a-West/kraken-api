using KrakenClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Kraken.Api.Controllers
{
    [RoutePrefix("orders")]
    public class OrdersController : ApiController
    {
        public KrakenClient.KrakenClient krakenClient = new KrakenClient.KrakenClient();
        // GET api/values
        [Route("")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var result = krakenClient.GetOpenOrders();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        // GET api/values/5
        [HttpGet]
        [Route("{txid}/{trades}/{userref}")]
        public HttpResponseMessage GetOrder(string txid, bool trades, string userref)
        {
            //trades defaults to false and userref to blank
            var result = krakenClient.QueryOrders(txid, trades, userref);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }



        // POST api/values
        [HttpPost]
        public HttpResponseMessage Post([FromBody]KrakenOrder order)
        {
            var result = krakenClient.AddOrder(order);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        //// PUT api/values/5
        //public void Put(int id, [FromBody]KrakenOrder order)
        //{
        //    var result = krakenClient.(order)
        //    return Request.CreateResponse(HttpStatusCode.OK, result);
        //}

        // DELETE api/values/5
        [HttpDelete]
        public HttpResponseMessage Delete(string txid)
        {
            var result = krakenClient.CancelOrder(txid);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
