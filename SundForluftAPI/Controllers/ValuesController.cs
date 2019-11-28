using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SundForluftAPI.Models;

namespace SundForluftAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly SundForluftContext _context;

        public ValuesController(SundForluftContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<ItemModel>> Get()
        {
            var values = _context.ItemModels;
            var @out = values.OrderBy(d => d.DateTime).Skip(values.Count() - 100);
            return Ok(@out);
        }

        // GET api/values/{last/start}/quantity
        [HttpGet("{from}/{quantity}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}