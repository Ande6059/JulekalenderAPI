using JulekalenderAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JulekalenderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LågeController : ControllerBase
    {
        private readonly LågeContext _context;

        public LågeController(LågeContext context)
        {
            _context = context;

            if (_context.Låger.Count() == 0) 
            {
                DbInitializer.Initialize(_context);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Låge>> Get()
        {
            return _context.Låger;
        }

        [HttpGet("{dag}", Name = "Get")]
        public List<Låge> Get(int dag)
        {
            List<Låge> lågeToGet = _context.Låger
                .Where(l => l.Dag == dag)
                .ToList();

            if (lågeToGet[0] == null)
            {
                NotFound();
            }
            return lågeToGet;
        }
    }
}
