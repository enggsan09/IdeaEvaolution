using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaEvalutorMVC.DomainObjects
{
    public class Judge
    {
        public List<Idea> Ideas { get; set; }
        public int JudgeId { get; set; }
        public string Name { get; set; }
        public Judge()
        {
            Ideas = new List<Idea>();
        }

        public void AssignIdea(Idea idea)
        {
            this.Ideas.Add(idea);
        }

        public int GetIdeaCount()
        {
            return Ideas.Count;
        }

        public List<Idea> GetIdeas()
        {
            if(Ideas.Count > 0)
            {
                return Ideas;
            }
            return new List<Idea>();
        }
    }
}