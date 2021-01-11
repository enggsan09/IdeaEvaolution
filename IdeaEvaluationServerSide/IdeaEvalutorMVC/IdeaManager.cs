using IdeaEvalutorMVC.Dal;
using IdeaEvalutorMVC.mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdeaEvalutorMVC.DomainObjects
{
    public class IdeaManager
    {
        private Mapper mapper = null;
        IdeaContext dal = new IdeaContext();

        Dictionary<int, List<Idea>> JudgesIdea = new Dictionary<int, List<Idea>>();
        int maxIdeaCount;

        public IdeaManager()
        {
            mapper = new Mapper(); 
            var ideas = dal.IdeaModels.ToList();
            var judges = dal.JudgeModels.ToList();
            AssignIdea(mapper.GetIdeaDTOList(ideas), mapper.GetJudgeDTOList(judges));
        }
        
        public List<Idea> GetData(int judgeId)
        {
            if(judgeId>0)
            {
                return JudgesIdea[judgeId];
            }
            return null;
        }
        public List<Judge> GetData()
        {
            List<Judge> jedges = new List<Judge>(); 
            foreach(KeyValuePair<int, List<Idea>> pair in JudgesIdea)
            {
                jedges.Add(new Judge
                {
                    JudgeId = pair.Key,
                    Ideas = pair.Value
                });
            }
            return jedges;
        }
        private void AssignIdea(List<Idea> ideasList, List<Judge> judges)
        {
            if (JudgesIdea.Keys.Count <= 0 && judges?.Count > 0 && ideasList?.Count > 0)
            {
                SetAllowedCount(judges.Count, ideasList.Count);
                foreach (Idea currIdea in ideasList)
                {
                    AssignIdea(currIdea, judges);
                }
            }
        }

        private void AssignIdea(Idea idea, List<Judge> judges)
        {
            if (judges?.Count > 0 && idea != null)
            {
                //for (int i = 0; i < maxIdeaCount; i++)
                //{
                    foreach (Judge judge in judges)
                    {
                        if(!JudgesIdea.Keys.Contains(judge.JudgeId))
                        {
                            JudgesIdea.Add(judge.JudgeId, new List<Idea>());
                        }
                        List<Idea> ideas = judge.GetIdeas();
                        if (!ideas.Any(curr => curr.IdeaId == idea.IdeaId))
                        {
                            //judge.AssignIdea(idea);
                            if (JudgesIdea[judge.JudgeId].Count >= maxIdeaCount)
                                continue;
                            JudgesIdea[judge.JudgeId].Add(idea);
                            break;
                        }

                    }
                //}

            }
        }        

        private void SetAllowedCount(int ideaCount, int JudgeCount)
        {
            maxIdeaCount = JudgeCount/ ideaCount;
        }
    }
}