using System;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearnerDestinationandProgressionDPOutcome : IDPOutcome
    {
        public DateTime? OutEndDateNullable
        {
            get { return outEndDateFieldSpecified ? (DateTime?)outEndDateField : null; }
        }
    }
}
