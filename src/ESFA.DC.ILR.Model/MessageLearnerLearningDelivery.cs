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
        public long? AddHoursNullable
        {
            get { return addHoursFieldSpecified ? (long?)addHoursField : null; }
        }

        [XmlIgnore]
        public long? EmpOutcomeNullable
        {
            get { return empOutcomeFieldSpecified ? (long?)empOutcomeField : null; }
        }

        [XmlIgnore]
        public long? FworkCodeNullable
        {
            get { return fworkCodeFieldSpecified ? (long?)fworkCodeField : null; }
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
        public long? OtherFundAdjNullable
        {
            get { return otherFundAdjFieldSpecified ? (long?)otherFundAdjField : null; }
        }

        [XmlIgnore]
        public long? OutcomeNullable
        {
            get { return outcomeFieldSpecified ? (long?)outcomeField : null; }
        }

        [XmlIgnore]
        public long? PartnerUKPRNNullable
        {
            get { return partnerUKPRNFieldSpecified ? (long?)partnerUKPRNField : null;  }
        }

        [XmlIgnore]
        public long? PriorLearnFundAdjNullable
        {
            get { return priorLearnFundAdjFieldSpecified ? (long?)priorLearnFundAdjField : null; }
        }

        [XmlIgnore]
        public long? ProgTypeNullable
        {
            get { return progTypeFieldSpecified ? (long?)progTypeField : null; }
        }

        [XmlIgnore]
        public long? PwayCodeNullable
        {
            get { return pwayCodeFieldSpecified ? (long?)pwayCodeField : null; }
        }

        [XmlIgnore]
        public long? StdCodeNullable
        {
            get { return stdCodeFieldSpecified ? (long?)stdCodeField : null; }
        }

        [XmlIgnore]
        public long? WithdrawReasonNullable
        {
            get { return withdrawReasonFieldSpecified ? (long?)withdrawReasonField : null;  }
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
