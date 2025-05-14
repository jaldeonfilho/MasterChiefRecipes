using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IMeasurementTypeService
    {
        public void AddMeasurementType(MeasurementType measurementType);
        public MeasurementType GetMeasurementTypeById(int measurementTypeId);
        public IEnumerable<MeasurementType> GetAllMeasurementTypes();
        public void UpdateMeasurementType(MeasurementType measurementType);
        public void RemoveMeasurementType(int measurementTypeId);

    }
}
