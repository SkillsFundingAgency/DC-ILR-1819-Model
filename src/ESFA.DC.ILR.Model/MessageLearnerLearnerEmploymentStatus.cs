using System;
using System.Collections.Generic;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearnerLearnerEmploymentStatus : ILearnerEmploymentStatus
    {
        public long? EmpIdNullable
        {
            get { return empIdFieldSpecified ? (long?)empIdField : null; }
        }
        
        public IReadOnlyCollection<IEmploymentStatusMonitoring> EmploymentStatusMonitorings
        {
            get { return employmentStatusMonitoringField;  }
        }
    }
}
