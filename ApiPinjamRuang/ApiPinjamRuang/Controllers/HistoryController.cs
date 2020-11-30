using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPinjamRuang.Models;
using ApiPinjamRuang.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPinjamRuang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly HistoryService _historyService;
        public HistoryController(HistoryService historyService)
        {
            _historyService = historyService;
        }

        [HttpGet]
        public ActionResult<List<History>> Get()
        {
            return _historyService.Get();
        }

        [HttpGet("{id:length(24)}", Name ="GetHistory")]
        public ActionResult<History> Get(string id)
        {
            var history = _historyService.Get(id);
            if (history == null)
            {
                return NotFound();
            }
            return history;
        }

        [HttpPost]
        public ActionResult<History> Create(History history)
        {
            _historyService.Create(history);
            return CreatedAtRoute("GetBook", new { id = history.id.ToString() }, history);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, History newHistory)
        {
            var history = _historyService.Get(id);
            if (history == null)
            {
                return NotFound();
            }

            _historyService.Update(id, newHistory);
            return NoContent();
        }
    }
}
