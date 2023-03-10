using System.Collections.Generic;
using System.Web.Http;


namespace TestGITAPI1.Controllers
{
    public class TextsController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "Text 1", "Text 2" };
        }

        public string Get(int id)
        {
            return $"Text: {id}";
        }
    }
}