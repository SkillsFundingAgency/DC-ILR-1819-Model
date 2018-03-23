using System;
using System.Collections.Generic;

namespace ESFA.DC.ILR.Model.Interface
{
    public interface ILearner
    {
        long? AccomNullable { get; }
        string AddLine1 { get; }
        string AddLine2 { get; }
        string AddLine3 { get; }
        string AddLine4 { get; }
        long? ALSCostNullable { get; }
        DateTime? DateOfBirthNullable { get; }
        string Email { get; }
        int Ethnicity { get; }
        string EngGrade { get; }
        string FamilyName { get; }
        string GivenNames { get; }
        string LearnRefNumber { get; }
        int LLDDHealthProb { get; }
        string MathGrade { get; }
        string NINumber { get; }
        long? PlanEEPHoursNullable { get; }
        long? PlanLearnHoursNullable { get; }
        long? PMUKPRNNullable { get; }
        string Postcode { get; }
        string PostcodePrior { get; }
        string PrevLearnRefNumber { get; }
        long? PrevUKPRNNullable { get; }
        long? PriorAttainNullable { get; }
        long ULN { get; }
        string Sex { get; }
        string TelNo { get; }

        ILearnerHE LearnerHEEntity { get; }
        IReadOnlyCollection<IContactPreference> ContactPreferences { get; }
        IReadOnlyCollection<ILearnerFAM> LearnerFAMs { get; }
        IReadOnlyCollection<ILearningDelivery> LearningDeliveries { get; }
        IReadOnlyCollection<ILLDDAndHealthProblem> LLDDAndHealthProblems { get; }
        IReadOnlyCollection<IProviderSpecLearnerMonitoring> ProviderSpecLearnerMonitorings { get; }
        IReadOnlyCollection<ILearnerEmploymentStatus> LearnerEmploymentStatuses { get; }
    }
}
