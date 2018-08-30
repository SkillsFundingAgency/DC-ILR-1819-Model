using ESFA.DC.ILR.Model.Interface;
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearnerLearningDelivery : ILearningDelivery
    {
        [XmlIgnore]
        public DateTime? AchDateNullable
        {
            get { return achDateFieldSpecified ? (DateTime?)achDateField : null; }
        }

        [XmlIgnore]
        public int? AddHoursNullable
        {
            get { return addHoursFieldSpecified ? (int?)addHoursField : null; }
        }

        [XmlIgnore]
        public int? EmpOutcomeNullable
        {
            get { return empOutcomeFieldSpecified ? (int?)empOutcomeField : null; }
        }

        [XmlIgnore]
        public int? FworkCodeNullable
        {
            get { return fworkCodeFieldSpecified ? (int?)fworkCodeField : null; }
        }        

        [XmlIgnore]
        public DateTime? LearnActEndDateNullable
        {
            get { return learnActEndDateFieldSpecified ? (DateTime?)learnActEndDateField : null; }
        }

        [XmlIgnore]
        public DateTime? OrigLearnStartDateNullable
        {
            get { return origLearnStartDateFieldSpecified ? (DateTime?)origLearnStartDateField : null; }
        }

        [XmlIgnore]
        public int? OtherFundAdjNullable
        {
            get { return otherFundAdjFieldSpecified ? (int?)otherFundAdjField : null; }
        }

        [XmlIgnore]
        public int? OutcomeNullable
        {
            get { return outcomeFieldSpecified ? (int?)outcomeField : null; }
        }

        [XmlIgnore]
        public int? PartnerUKPRNNullable
        {
            get { return partnerUKPRNFieldSpecified ? (int?)partnerUKPRNField : null;  }
        }

        [XmlIgnore]
        public int? PriorLearnFundAdjNullable
        {
            get { return priorLearnFundAdjFieldSpecified ? (int?)priorLearnFundAdjField : null; }
        }

        [XmlIgnore]
        public int? ProgTypeNullable
        {
            get { return progTypeFieldSpecified ? (int?)progTypeField : null; }
        }

        [XmlIgnore]
        public int? PwayCodeNullable
        {
            get { return pwayCodeFieldSpecified ? (int?)pwayCodeField : null; }
        }

        [XmlIgnore]
        public int? StdCodeNullable
        {
            get { return stdCodeFieldSpecified ? (int?)stdCodeField : null; }
        }

        [XmlIgnore]
        public int? WithdrawReasonNullable
        {
            get { return withdrawReasonFieldSpecified ? (int?)withdrawReasonField : null;  }
        }
         
        [XmlIgnore]
        public ILearningDeliveryHE LearningDeliveryHEEntity
        {
            get { return learningDeliveryHEField; }
        }

        [XmlIgnore]
        public IReadOnlyCollection<IAppFinRecord> AppFinRecords
        {
            get { return appFinRecordField; }
        }

        [XmlIgnore]
        public IReadOnlyCollection<ILearningDeliveryFAM> LearningDeliveryFAMs
        {
            get { return learningDeliveryFAMField; }
        }

        public IReadOnlyCollection<ILearningDeliveryWorkPlacement> LearningDeliveryWorkPlacements
        {
            get { return learningDeliveryWorkPlacementField; }
        }

        public IReadOnlyCollection<IProviderSpecDeliveryMonitoring> ProviderSpecDeliveryMonitorings
        {
            get { return providerSpecDeliveryMonitoringField; }
        }
    }
}
