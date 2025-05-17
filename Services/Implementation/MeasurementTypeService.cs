using Models;
using Repository;
using Service.Interfaces;

namespace Service.Implementation
{
    public class MeasurementTypeService : GenericService<MeasurementType>, IMeasurementTypeService
    {
        public MeasurementTypeService(IGenericRepository<MeasurementType> repository)
            : base(repository)
        {
        }

    }
}