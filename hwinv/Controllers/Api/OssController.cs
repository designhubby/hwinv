using AutoMapper;
using hwinv.Dtos;
using hwinv.Models;
using System;
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
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}