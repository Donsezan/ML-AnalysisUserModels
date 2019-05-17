using System;
using System.Collections.Generic;

namespace WindowsFormsMLTest.Rules
{
    public class GameSessionLengthStd : IRule
    {
        private List<BlobDataContract> _list;
        public GameSessionLengthStd(List<BlobDataContract> list)
        {
            _list = list;
        }
        public List<BlobDataContract> RuleForList(string[] countryKey, bool stat)
        {
            var newList = new List<BlobDataContract>();
            foreach (var blob in _list)
            {
                var value = Convert.ToDouble(blob.game_session_length_std);
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