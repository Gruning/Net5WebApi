using System.Collections.Generic;
using Net5WebApi.Models;

namespace Net5WebApi.Data
{
    public class MockSnippetRepo : ISnippetRepository{
        public IEnumerable<Snippet> GetAllSnippets(){
            return null; 
        }
        public Snippet GetSnippetById(int id){
            return new Snippet{id =0} 
        }
    }
}