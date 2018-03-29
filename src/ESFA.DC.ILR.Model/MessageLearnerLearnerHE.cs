using System.Collections.Generic;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearnerLearnerHE : ILearnerHE
    {
        public int? TTACCOMNullable
        {
            get { return tTACCOMFieldSpecified ? (int?)tTACCOMField : null; }
        }

        public IReadOnlyCollection<ILearnerHEFinancialSupport> LearnerHEFinancialSupports
        {
            get { return learnerHEFinancialSupportField; }
        }
    }
}
