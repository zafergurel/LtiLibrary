﻿using System;

namespace LtiLibrary.Core.Outcomes
{
    [Obsolete("Use LtiLibrary.Core.Outcomes.v1.LisResult")]
    public class LisResult
    {
        public bool IsValid { get; set; }
        public double? Score { get; set; }
        public string SourcedId { get; set; }
    }
}