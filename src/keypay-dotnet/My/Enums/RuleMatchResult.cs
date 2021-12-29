using System;
using System.Collections.Generic;

namespace KeyPayV2.My.Enums
{
    public enum RuleMatchResult
    {
        NoMatch,
        Match,
        DisabledForRuleSet,
        DisabledForEmployee,
        ExcludedCustomRule
    }
}
