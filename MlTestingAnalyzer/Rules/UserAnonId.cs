using System.Collections.Generic;

namespace WindowsFormsMLTest.Rules
{
    public class UserAnonId : IRule
    {

        private List<BlobDataContract> _list;

        public UserAnonId(List<BlobDataContract> list)
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
                        if (blob.user_anon_id.Contains(key))
                        {
                            newList.Add(blob);
                            break;
                        }
                    }
                    else
                    {
                        if (!blob.user_anon_id.Contains(key))
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