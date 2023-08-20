using System;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Models;
using ClassLibrary.DataAccess;

namespace ClassLibrary.DataService
{
    public class DataService
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
    }
}