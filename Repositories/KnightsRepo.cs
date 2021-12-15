using System.Data;

namespace knights.Repositories
{
    public class KnightsRepository
    {
        private readonly IDbConnection _db;
        public KnightsRepository(IDbConnection db)
        {
            _db = db;
        }
    }
}