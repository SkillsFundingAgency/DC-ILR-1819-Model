using System;
using System.Collections.Generic;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearnerLearnerEmploymentStatus : ILearnerEmploymentStatus
    {
        public int? EmpIdNullable
        {
            get { return empIdFieldSpecified ? (int?)empIdField : null; }
        }
        
        public IReadOnlyCollection<IEmploymentStatusMonitoring> EmploymentStatusMonitorings
        {
            get { return employmentStatusMonitoringField;  }
        }
    }
}
