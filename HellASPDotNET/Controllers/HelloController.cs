using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HellASPDotNET.Controllers
{
    [Route("/helloworld")]

    public class HelloController : Controller
    {
        

        // GET: /<controller>/

        [HttpGet]

        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld'>" +
       "<input type='text' name='name' />" +
       "<select name='language'>" +
           "<option value='select'>Select language</option>" +
           "<option value='english'>English</option>" +
           "<option value='arabic'>Arabic</option>" +
           "<option value='tgregna'>Tgregna</option>" +
           "<option value='hindi'>Hindi</option>" +
           "<option value='spanish'>Spanish</option>" +
            "<option value='french'>French</option>" +
       "</select>" +
       "<input type='submit' value='Greet Me!' />" +
       "</form>";

            return Content(html, "text/html");
        }
        //Post: /"helloworld/Message
        
        [HttpPost]
        public IActionResult Message(string name, string language)
        {
            string greeting = "";
            if (language.Equals("select"))
            { greeting = "you did not select language  ," + name; }

            else if (language.Equals("english"))
            { greeting = "Hello  ," + name; }

            else if (language.Equals("arabic"))
            { greeting = "Marhaba  ," + name; }

            else if (language.Equals("hindi"))
            { greeting = "Namaste  ," + name; }

            else if (language.Equals("tgregna"))
            { greeting ="Selam  ," + name; }

            else if (language.Equals("spanish"))
            { greeting ="Hola  ," + name; }

            else if (language.Equals("french"))
            { greeting = "Bonjour  ," + name; }

            return Content("<h1>" + greeting + "!", "text/html");

        }
    }
}
