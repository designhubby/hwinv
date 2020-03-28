using AutoMapper;
using hwinv.Dtos;
using hwinv.Models;
using System;
using System.Net;
using System.Linq;
using System.Web.Http;


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
        [HttpGet]
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
        [HttpGet]
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
        [HttpPost]
        // POST api/<controller>
        public IHttpActionResult CreateOss(OsDto osDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var DB_Item_Os = Mapper.Map<OsDto, Os>(osDto);
            _context.Os.Add(DB_Item_Os);
            _context.SaveChanges();
            osDto.OsId = DB_Item_Os.OsId;

            return Created(new Uri(Request.RequestUri + "/" + osDto.OsId), osDto);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public IHttpActionResult UpdateOss(int id, OsDto osDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var Dto_Item_Os_id = osDto.OsId;

            var Db_Item_Os = _context.Os.SingleOrDefault(o => o.OsId == id);
            
            if (Db_Item_Os == null)
            {
                return NotFound();
            }
            Mapper.Map<OsDto, Os>(osDto, Db_Item_Os);
            _context.SaveChanges();

            return Ok(osDto);
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var Db_Item_Oss = _context.Os.SingleOrDefault(o => o.OsId == id);
            if(Db_Item_Oss == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            _context.Os.Remove(Db_Item_Oss);
            _context.SaveChanges();

            return Ok();
        }
    }
}