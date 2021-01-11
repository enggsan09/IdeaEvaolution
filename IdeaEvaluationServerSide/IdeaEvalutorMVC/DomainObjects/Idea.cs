using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaEvalutorMVC.DomainObjects
{
    public class Idea
    {
        public Idea()
        {

        }
        public int IdeaId { get; set; }
        public string IdeaName { get; set; }
        public string Discription { get; set; }
    }
}