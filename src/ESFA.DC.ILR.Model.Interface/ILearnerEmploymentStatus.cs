using System;
using System.Collections.Generic;

namespace ESFA.DC.ILR.Model.Interface
{
    public interface ILearnerEmploymentStatus
    {
        int EmpStat { get; }
        DateTime DateEmpStatApp { get; }
        long? EmpIdNullable { get; }        

        IReadOnlyCollection<IEmploymentStatusMonitoring> EmploymentStatusMonitorings { get; }
    }
}
