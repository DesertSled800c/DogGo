using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IWalkRepository
    {
        List<Walks> GetAllWalks();
        Walks GetWalkById(int id);
        List<Walks> GetWalksByWalkerId(int id);
        void AddWalk(Walks walk);
        void UpdateWalk(Walks walk);
        void DeleteWalk(int walkId);
    }
}