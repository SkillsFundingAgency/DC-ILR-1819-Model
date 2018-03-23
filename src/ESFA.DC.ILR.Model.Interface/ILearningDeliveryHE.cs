namespace ESFA.DC.ILR.Model.Interface
{
    public interface ILearningDeliveryHE
    {
        string NUMHUS { get; }
        string SSN { get; }
        string QUALENT3 { get; }
        long? SOC2000Nullable { get; }
        long? SECNullable { get; }
        string UCASAPPID { get; }
        int TYPEYR { get; }
        int MODESTUD { get; }
        int FUNDLEV { get; }
        int FUNDCOMP { get; }
        decimal? STULOADNullable { get; }
        int YEARSTU { get; }
        int MSTUFEE { get; }
        decimal? PCOLABNullable { get; }
        decimal? PCFLDCSNullable { get; }
        decimal? PCSLDCSNullable { get; }
        decimal? PCTLDCSNullable { get; }
        int SPECFEE { get; }
        long? NETFEENullable { get; }
        long? GROSSFEENullable { get; }
        string DOMICILE { get; }
        long? ELQNullable { get; }
        string HEPostCode { get; }
    }
}
