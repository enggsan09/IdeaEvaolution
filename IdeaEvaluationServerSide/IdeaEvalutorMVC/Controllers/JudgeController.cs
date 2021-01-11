using IdeaEvalutorMVC.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IdeaEvalutorMVC.Controllers
{
    public class JudgeController : ApiController
    {

        // GET api/{Judge}/{GetJudge}/{id}
        public Judge GetJudge(int id)
        {
            Judge judge = new Judge { JudgeId = id };
            IdeaManager manager = new IdeaManager();
            judge.Ideas = manager.GetData(id);
            return judge;
        }

        [Route("api/Judge/GetJugdeList")]
        public List<Judge> GetJugdeList()

        {
            Judge judge = new Judge();
            IdeaManager manager = new IdeaManager();
            return manager.GetData();
        }
    }
}
