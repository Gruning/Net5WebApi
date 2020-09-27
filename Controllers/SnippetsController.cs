using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Net5WebApi.Models;
using Net5WebApi.Data;
namespace Net5WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SnippetsController: ControllerBase
    {
        //private readonly ISnippetRepository _repository;
        // public SnippetsController(ISnippetRepository repository)
        // {
        //     _repository = repository;
        // }

        private readonly MockSnippetRepo _repository = new MockSnippetRepo();
        [HttpGet]
        public ActionResult<IEnumerable<Snippet>> GetAllSnippets()
        {
            var SnippetItems =  _repository.GetAllSnippets();
            return Ok();
        }
        [HttpGet]
        public ActionResult<Snippet> GetSnippetById( int id)
        {
            var SnippetItems =  _repository.GetSnippetById(id);
            return Ok();
        }
    }
}