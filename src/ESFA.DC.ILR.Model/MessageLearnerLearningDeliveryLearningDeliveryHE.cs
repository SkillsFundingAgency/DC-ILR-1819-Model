using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Model
{
    public partial class MessageLearnerLearningDeliveryLearningDeliveryHE : ILearningDeliveryHE
    {
        public int? SOC2000Nullable
        {
            get { return sOC2000FieldSpecified ? (int?)sOC2000Field : null; }
        }

        public int? SECNullable
        {
            get { return sECFieldSpecified ? (int?)sECField : null; }
        }
        
        public decimal? STULOADNullable
        { 
            get { return sTULOADFieldSpecified? (decimal?) sTULOADField : null; }
        }
        
        public decimal? PCOLABNullable
        {
            get { return pCOLABFieldSpecified ? (decimal?)pCOLABField : null; }
        }

        public decimal? PCFLDCSNullable
        {
            get { return pCFLDCSFieldSpecified ? (decimal?)pCFLDCSField : null; }
        }

        public decimal? PCSLDCSNullable
        {
            get { return pCSLDCSFieldSpecified ? (decimal?)pCSLDCSField : null; }
        }

        public decimal? PCTLDCSNullable
        {
            get { return pCTLDCSFieldSpecified ? (decimal?)pCTLDCSField : null; }
        }
        
        public int? NETFEENullable
        {
            get { return nETFEEFieldSpecified ? (int?)nETFEEField : null; }
        }

        public int? ELQNullable
        {
            get { return eLQFieldSpecified ? (int?)eLQField : null; }
        }

        public int? GROSSFEENullable
        {
            get
            {
                return gROSSFEEFieldSpecified ? (int?)gROSSFEEField : null;
            }
        }
    }
}
