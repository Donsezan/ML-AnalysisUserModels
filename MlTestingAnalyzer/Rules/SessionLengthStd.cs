﻿using System;
using System.Collections.Generic;

namespace WindowsFormsMLTest.Rules
{
    public class SessionLengthStd : IRule
    {

        private List<BlobDataContract> _list;
        public SessionLengthStd(List<BlobDataContract> list)
        {
            _list = list;
        }
        public List<BlobDataContract> RuleForList(string[] countryKey, bool stat)
        {
            var newList = new List<BlobDataContract>();
            foreach (var blob in _list)
            {
                var value = Convert.ToDouble(blob.session_length_mean);
                var filterValue = Convert.ToDouble(countryKey[0]);
                if (stat)
                {
                    if (value > filterValue)
                    {
                        newList.Add(blob);
                    }
                }
                else
                {
                    if (value < filterValue)
                    {
                        newList.Add(blob);
                    }
                }
            }

            return newList;
        }
    }
}