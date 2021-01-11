using IdeaEvalutorMVC.DomainObjects;
using IdeaEvalutorMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaEvalutorMVC.mapper
{
    public class Mapper
    {
        internal List<Judge> GetJudgeDTOList(List<JudgeEO> eos)
        {
            if (eos?.Count > 0)
            {
                List<Judge> judgeList = new List<Judge>();
                foreach (JudgeEO eo in eos)
                {
                    judgeList.Add(MapJudge(eo));
                }
                return judgeList;
            }
            return null;
        }
        private Judge MapJudge(JudgeEO eo)
        {
            return new Judge
            {
                JudgeId = eo.Id,
                Name = eo.Name
            };
        }
        internal List<Idea> GetIdeaDTOList(List<IdeaEO> eos)
        {if (eos?.Count > 0)
            {
                List<Idea> ideaList= new List<Idea>();
                foreach (IdeaEO eo in eos)
                {
                    ideaList.Add(MapIdea(eo));
                }
                return ideaList;
            }
            return null;
        }

        private Idea MapIdea(IdeaEO eo)
        {
            return new Idea
            {
                IdeaId = eo.Id,
                IdeaName = eo.Name,
                Discription = eo.Discription

            };
        }
    }
}