using System;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Models;
using ClassLibrary.DataAccess;

namespace ClassLibrary.DataService
{
    public class DataService : IDataService
    {
        private readonly ISqlDataAccess _dataAccess;

        public DataService(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<List<IBugModel>> ReadAllBugs()
        {
            var bugs = await _dataAccess.LoadData<BugModel, dynamic>
                ("spBugs_ReadAll", new { }, "Default");
            return bugs.ToList<IBugModel>();
        }

        public async Task<List<ICreatureModel>> ReadAllCreatures()
        {
            var creatures = await _dataAccess.LoadData<CreatureModel, dynamic>
                ("spCreatures_ReadAll", new { }, "Default");
            return creatures.ToList<ICreatureModel>();
        }

        public async Task<List<IFishModel>> ReadAllFish()
        {
            var fish = await _dataAccess.LoadData<FishModel, dynamic>
                ("spFish_ReadAll", new { }, "Default");
            return fish.ToList<IFishModel>();
        }

        public async Task<List<IBugModel>> NorthBugsCurrent()
        {
            DateTime dt = DateTime.Now;
            int currentMonth = dt.Month;
            int currentHour = dt.Hour;
            var bugs = await _dataAccess.LoadData<BugModel, dynamic>
                ("spBugs_ReadAll", new { }, "Default");
            return bugs.ToList<IBugModel>();
        }
    }
}