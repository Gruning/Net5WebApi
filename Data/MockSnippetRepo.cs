using System.Collections.Generic;
using Net5WebApi.Models;

namespace Net5WebApi.Data
{
    public class MockSnippetRepo : ISnippetRepository{
        public IEnumerable<Snippet> GetAllSnippets(){
            return new List<Snippet>{
                    new Snippet{
                id =1, 
                HowTo="last argument"
                Line="!$"
                Platform="bash"},
                    new Snippet{
                id =1, 
                HowTo="current folder"
                Line=" ./ "
                Platform="bash"},
                    new Snippet{
                id =1, 
                HowTo="parent folder"
                Line=" ../ "
                Platform="bash"},
            }; 
        }
        public Snippet GetSnippetById(int id){
            return new Snippet{
                id =0, 
                HowTo="go to prev. folder"
                Line="cd -"
                Platform="bash"} 
        }
    }
}