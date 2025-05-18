using Models;
using Repository;
using Service.Interfaces;

namespace Service.Implementation
{
    public class MeasurementTypeService : GenericService<MeasurementTypeDto>, IMeasurementTypeService
    {
        public MeasurementTypeService(IGenericRepository<MeasurementTypeDto> repository)
            : base(repository)
        {
        }

    }
}