using ESFA.DC.ILR.Model.Interface;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearner : ILearner
    {
        [XmlIgnore]
        public int? AccomNullable
        {
            get { return accomFieldSpecified ? (int?)accomField : null; }
        }
        
        [XmlIgnore]
        public int? ALSCostNullable
        {
            get { return aLSCostFieldSpecified ? (int?)aLSCostField : null; }
        }

        [XmlIgnore]
        public DateTime? DateOfBirthNullable
        {
            get { return dateOfBirthFieldSpecified ? (DateTime?)dateOfBirthField : null; }
        }
        
        [XmlIgnore]
        public int? PlanEEPHoursNullable
        {
            get { return planEEPHoursFieldSpecified ? (int?)planEEPHoursField : null; }
        }

        [XmlIgnore]
        public int? PlanLearnHoursNullable
        {
            get { return planLearnHoursFieldSpecified ? (int?)planLearnHoursField : null; }
        }
        
        [XmlIgnore]
        public int? PMUKPRNNullable
        {
            get { return pMUKPRNFieldSpecified ? (int?)pMUKPRNField : null; }
        }

        [XmlIgnore]
        public int? PrevUKPRNNullable
        {
            get { return prevUKPRNFieldSpecified ? (int?)prevUKPRNField : null; }
        }

        [XmlIgnore]
        public int? PriorAttainNullable
        {
            get { return priorAttainFieldSpecified ? (int?)priorAttainField : null; }
        }
        
        [XmlIgnore]
        public IReadOnlyCollection<IContactPreference> ContactPreferences
        {
            get { return contactPreferenceField; }
        }

        [XmlIgnore]
        public IReadOnlyCollection<ILearnerEmploymentStatus> LearnerEmploymentStatuses
        {
            get { return learnerEmploymentStatusField; }
        }

        [XmlIgnore]
        public IReadOnlyCollection<ILearnerFAM> LearnerFAMs
        {
            get { return learnerFAMField; }
        }

        [XmlIgnore]
        public ILearnerHE LearnerHEEntity
        {
            get { return learnerHEField; }
        }

        [XmlIgnore]
        public IReadOnlyCollection<ILearningDelivery> LearningDeliveries
        {
            get { return learningDeliveryField; }
        }

        [XmlIgnore]
        public IReadOnlyCollection<ILLDDAndHealthProblem> LLDDAndHealthProblems
        {
            get { return lLDDandHealthProblemField; }
        }

        [XmlIgnore]
        public IReadOnlyCollection<IProviderSpecLearnerMonitoring> ProviderSpecLearnerMonitorings
        {
            get { return providerSpecLearnerMonitoringField; }
        }
    }
}
