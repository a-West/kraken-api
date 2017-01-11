﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using KrakenClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kraken.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CurrencyController : Controller
    {

        public KrakenClient.KrakenClient kraken;
        CurrencyController()
        {
            kraken = new KrakenClient.KrakenClient();
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var result = kraken.GetAssetPairs();
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
