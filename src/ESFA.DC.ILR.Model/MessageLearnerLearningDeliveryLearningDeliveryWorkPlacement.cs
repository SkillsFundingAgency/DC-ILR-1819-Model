using System;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearnerLearningDeliveryLearningDeliveryWorkPlacement : ILearningDeliveryWorkPlacement
    {
        public DateTime? WorkPlaceEndDateNullable
        {
            get { return workPlaceEndDateFieldSpecified ? (DateTime?)workPlaceEndDateField : null;  }
        }
        
        public int? WorkPlaceEmpIdNullable
        {
            get { return workPlaceEmpIdFieldSpecified ? (int?)workPlaceEmpIdField : null; }
        }
    }
}
