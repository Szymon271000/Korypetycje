using CheckList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckList.Data
{
    public interface ITaskRepository
    {
        List<Goal> GetAllGoals();
        Goal GetGoal(int goalId);

        void RemoveGoal(int goalId);
        void AddTask(Goal goal);
    }
}
