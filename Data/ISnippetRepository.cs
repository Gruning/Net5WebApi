using System.Collections.Generic;
using Net5WebApi.Models;
namespace Net5WebApi.Data
{
    public interface ISnippetRepository
    {
        IEnumerable<Snippet> GetAllSnippets();
        Snippet GetSnippetById(int id);
    }
}