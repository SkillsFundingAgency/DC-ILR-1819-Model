﻿using System;
using System.Collections.Generic;
using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Tests.Model
{
    public class TestLearningDelivery : ILearningDelivery
    {
        public DateTime? AchDateNullable { get; set; }

        public long? AddHoursNullable { get; set; }

        public int AimSeqNumber { get; set; }

        public int AimType { get; set; }

        public int CompStatus { get; set; }

        public string ConRefNumber { get; set; }

        public string DelLocPostCode { get; set; }

        public long? EmpOutcomeNullable { get; set; }

        public string EPAOrgID { get; set; }

        public int FundModel { get; set; }

        public long? FworkCodeNullable { get; set; }

        public string LearnAimRef { get; set; }

        public DateTime? LearnActEndDateNullable { get; set; }

        public DateTime LearnPlanEndDate { get; set; }

        public DateTime LearnStartDate { get; set; }

        public DateTime? OrigLearnStartDateNullable { get; set; }

        public long? OtherFundAdjNullable { get; set; }

        public long? OutcomeNullable { get; set; }

        public string OutGrade { get; set; }

        public long? PartnerUKPRNNullable { get; set; }

        public long? PriorLearnFundAdjNullable { get; set; }

        public long? ProgTypeNullable { get; set; }

        public long? PwayCodeNullable { get; set; }

        public long? StdCodeNullable { get; set; }

        public string SWSupAimId { get; set; }

        public long? WithdrawReasonNullable { get; set; }

        public ILearningDeliveryHE LearningDeliveryHEEntity { get; set; }

        public IReadOnlyCollection<IAppFinRecord> AppFinRecords { get; set; }

        public IReadOnlyCollection<ILearningDeliveryFAM> LearningDeliveryFAMs { get; set; }

        public IReadOnlyCollection<ILearningDeliveryWorkPlacement> LearningDeliveryWorkPlacements { get; set; }

        public IReadOnlyCollection<IProviderSpecDeliveryMonitoring> ProviderSpecDeliveryMonitorings { get; set; }
    }
}
