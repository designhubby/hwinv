using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using AutoMapper;
using System.Web.Http;
using hwinv.Models;
using hwinv.Dtos;

namespace hwinv.Controllers.Api
{
    [AllowAnonymous]
    public class OssController : ApiController
    {
        private ApplicationDbContext _context;
        public OssController()
        {
            _context = new ApplicationDbContext();
        }

        // GET api/<controller>
        public IEnumerable<OsDto> GetOss()
        {
            return _context.Os.ToList().Select(Mapper.Map<Os, OsDto>);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}