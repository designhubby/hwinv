using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data.Entity;
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
        public IHttpActionResult GetOss(int id)
        {
            var item_os = _context.Os.SingleOrDefault(o => o.OsId == id);

            if(item_os == null)
            {
                return NotFound();
            }

            var item_os_dto = Mapper.Map<Os, OsDto>(item_os);

            return Ok(item_os_dto);
        }

        // GET api/<controller>/5
        public IHttpActionResult GetOss(string name = null)
        {
            var list_os =  _context.Os.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                list_os =  list_os
                    .Where(o => o.OsName.Contains(name));
            }
            var list_os_dto = list_os.ToList().Select(Mapper.Map<Os, OsDto>);

            return Ok(list_os_dto) ;
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