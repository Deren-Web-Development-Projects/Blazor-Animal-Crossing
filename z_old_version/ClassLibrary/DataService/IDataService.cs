using ClassLibrary.Models;

namespace ClassLibrary.DataService
{
    public interface IDataService
    {
        Task<List<IBugModel>> ReadAllBugs();
        Task<List<ICreatureModel>> ReadAllCreatures();
        Task<List<IFishModel>> ReadAllFish();
    }
}