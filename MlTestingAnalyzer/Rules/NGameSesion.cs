using System;
using System.Collections.Generic;

namespace WindowsFormsMLTest.Rules
{
    public class NGameSesion : IRule
    {
        private List<BlobDataContract> _list;
        public NGameSesion(List<BlobDataContract> list)
        {
            _list = list;
        }
        public List<BlobDataContract> RuleForList(string[] countryKey, bool stat)
        {
            var newList = new List<BlobDataContract>();
            foreach (var blob in _list)
            {
                var value = Convert.ToDouble(blob.n_game_session);
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