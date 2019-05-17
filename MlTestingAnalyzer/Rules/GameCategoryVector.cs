using System;
using System.Collections.Generic;

namespace WindowsFormsMLTest.Rules
{
    public class GameCategoryVector : IRule
    {

        private List<BlobDataContract> _list;
        public GameCategoryVector(List<BlobDataContract> list)
        {
            _list = list;
        }
        public List<BlobDataContract> RuleForList(string[] countryKey, bool stat)
        {
            var transformToInt = new double[countryKey.Length];

            for (int i = 0; i < countryKey.Length; i++)
            {
                transformToInt[i] = Convert.ToDouble(countryKey[i]);
            }

            var newList = new List<BlobDataContract>();
            foreach (var blob in _list)
            {
                var enterVectors = blob.game_category_vector.Split(',');
                var enteredTransformToInt = new double[enterVectors.Length];

                for (int i = 0; i < enterVectors.Length; i++)
                {
                    enteredTransformToInt[i] = Convert.ToDouble(enterVectors[i]);
                }
                var innerStatus = false;
                for (var i = 0; i < enterVectors.Length - 1; i++)
                {
                    if (countryKey[i] != "0")
                    {
                        innerStatus = CheckStatus(stat, transformToInt[i], enteredTransformToInt[i]);
                    }
                }
                if (innerStatus)
                {
                    newList.Add(blob);
                }
            }

            return newList;
        }

        private bool CheckStatus(bool stat, double enter, double user)
        {
            if (stat)
            {
                return enter > user;
            }
            else
            {
                return enter < user;
            }
        }


    }
}