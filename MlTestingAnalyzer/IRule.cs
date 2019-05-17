using System;
using System.Collections.Generic;

namespace WindowsFormsMLTest
{
    public interface IRule
    {
        List<BlobDataContract> RuleForList(string[] countryKey, bool status);
    }
}