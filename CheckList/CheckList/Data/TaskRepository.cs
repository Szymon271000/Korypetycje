using CheckList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckList.Data
{
    public class TaskRepository: ITaskRepository
    {
        private readonly DataContext context;

        public TaskRepository(DataContext context)
        {
            this.context = context;
        }

        public void AddTask(Goal goal)
        {
            context.Add(goal);
            context.SaveChanges();
        }

        public List<Goal> GetAllGoals()
        {
            return context.goals.ToList();
        }

        //public List<Goal> GetDone()
        //{
        //    return context.goals.Where(x => x.Done).ToList();
        //}

        public Goal GetGoal(int goalId)
        {
            return context.goals.FirstOrDefault(x => x.Id == goalId);
            
        }

        public void SetDone(int goalId)
        {
            var goal = context.goals.FirstOrDefault(x => x.Id == goalId);
            if (goal == null)
            {
                return;
            }
            goal.Done = true;
            context.SaveChanges();
        }

        public void RemoveGoal(int goalId)
        {
            var goal = context.goals.FirstOrDefault(x => x.Id == goalId);
            if (goal == null)
            {
                return;
            }
            context.Remove(goal);
            context.SaveChanges();
        }

        public void SetUnDone(int goalId)
        {
            var goal = context.goals.FirstOrDefault(x => x.Id == goalId);
            if (goal == null)
            {
                return;
            }
            goal.Done = false;
            context.SaveChanges();
        }
    }
}
