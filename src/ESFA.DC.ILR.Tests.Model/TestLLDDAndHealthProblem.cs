﻿using ESFA.DC.ILR.Model.Interface;

namespace ESFA.DC.ILR.Tests.Model
{
    public class TestLLDDAndHealthProblem : ILLDDAndHealthProblem
    {
        public int LLDDCat { get; set; }

        public long? PrimaryLLDDNullable { get; set; }
    }
}
