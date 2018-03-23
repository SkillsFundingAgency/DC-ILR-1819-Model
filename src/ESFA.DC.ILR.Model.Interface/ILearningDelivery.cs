using System;
using System.Collections.Generic;

namespace ESFA.DC.ILR.Model.Interface
{
    public interface ILearningDelivery
    {
        DateTime? AchDateNullable { get; }
        long? AddHoursNullable { get; }
        int AimSeqNumber { get; }
        int AimType { get; }
        int CompStatus { get; }
        string ConRefNumber { get; }
        string DelLocPostCode { get; }
        long? EmpOutcomeNullable { get; }
        string EPAOrgID { get; }
        int FundModel { get; }
        long? FworkCodeNullable { get; }
        string LearnAimRef { get; }
        DateTime? LearnActEndDateNullable { get; }
        DateTime LearnPlanEndDate { get; }
        DateTime LearnStartDate { get; }
        DateTime? OrigLearnStartDateNullable { get; }
        long? OtherFundAdjNullable { get; }
        long? OutcomeNullable { get; }
        string OutGrade { get; }
        long? PartnerUKPRNNullable { get; }
        long? PriorLearnFundAdjNullable { get; }
        long? ProgTypeNullable { get; }
        long? PwayCodeNullable { get; }
        long? StdCodeNullable { get; }
        string SWSupAimId { get; }
        long? WithdrawReasonNullable { get; }

        ILearningDeliveryHE LearningDeliveryHEEntity { get; }
        IReadOnlyCollection<IAppFinRecord> AppFinRecords { get; }
        IReadOnlyCollection<ILearningDeliveryFAM> LearningDeliveryFAMs { get; }
        IReadOnlyCollection<ILearningDeliveryWorkPlacement> LearningDeliveryWorkPlacements { get; }
        IReadOnlyCollection<IProviderSpecDeliveryMonitoring> ProviderSpecDeliveryMonitorings { get; }        
    }
}
