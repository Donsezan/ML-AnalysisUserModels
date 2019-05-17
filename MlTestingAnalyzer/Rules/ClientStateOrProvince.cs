using System.Collections.Generic;

namespace WindowsFormsMLTest.Rules
{
    public class ClientStateOrProvince : IRule
    {
        private List<BlobDataContract> _list;
        public ClientStateOrProvince(List<BlobDataContract> list)
        {
            _list = list;
        }
        public List<BlobDataContract> RuleForList(string[] countryKey, bool stat)
        {
            var newList = new List<BlobDataContract>();
            foreach (var blob in _list)
            {
                foreach (var key in countryKey)
                {
                    if (stat)
                    {
                        if (blob.client_StateOrProvince.Contains(key))
                        {
                            newList.Add(blob);
                            break;
                        }
                    }
                    else
                    {
                        if (!blob.client_StateOrProvince.Contains(key))
                        {
                            newList.Add(blob);
                            break;
                        }
                    }
                }
            }
            return newList;
        }
    }
}