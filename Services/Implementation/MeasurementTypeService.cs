using Models;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class MeasurementTypeService : IMeasurementTypeService
    {
        private readonly IMeasurementTypeRepository _measurementTypeRepository;

        public MeasurementTypeService(IMeasurementTypeRepository measurementTypeRepository)
        {
            _measurementTypeRepository = measurementTypeRepository;
        }

        public void AddMeasurementType(MeasurementType measurementType)
        {
            _measurementTypeRepository.AddMeasurementType(measurementType);
        }

        public MeasurementType GetMeasurementTypeById(int measurementTypeId)
        {
            return _measurementTypeRepository.GetMeasurementTypeById(measurementTypeId);
        }

        public IEnumerable<MeasurementType> GetAllMeasurementTypes()
        {
            return _measurementTypeRepository.GetAllMeasurementTypes();
        }

        public void UpdateMeasurementType(MeasurementType measurementType)
        {
            _measurementTypeRepository.UpdateMeasurementType(measurementType);
        }

        public void RemoveMeasurementType(int measurementTypeId)
        {
            _measurementTypeRepository.RemoveMeasurementType(measurementTypeId);
        }
    }
}
