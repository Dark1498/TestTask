using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Server2.Models;

namespace Server2.Controllers
{
    public class WordsController : ApiController
    {
        static readonly WordRepository repository = new WordRepository(); 
        // GET: api/Words
        public IEnumerable<Word> Get()
        {
            return repository.GetAll();
        }

        // POST: api/Words
        public void Post(Word word)
        {
            repository.Add(word);
            repository.WordsToArray(word);
        }
        
       
        
    }
}
