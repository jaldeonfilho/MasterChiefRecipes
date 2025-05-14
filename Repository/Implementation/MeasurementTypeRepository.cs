using Repository.Context;
using Repository.Interfaces;

namespace Repository.Implementation
{
    public class MeasurementTypeRepository : GenericRepository<MeasurementTypeRepository>, IMeasurementTypeRepository
    {
        public MeasurementTypeRepository(DbContextRecipe context)
           : base(context) { }

    }
}
