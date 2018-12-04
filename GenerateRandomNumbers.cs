using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Generator
{
    class RandomNum
    {
        private Random rand;

        public RandomNum()
        {
            rand = new Random();
        }

        private List<int> GenerateRandomNumbers(List<int> possibleValuesList,
            int numberOfNumbers, List<int> returnList)
        {
            if (returnList.Count == numberOfNumbers)
            {
                return returnList;
            }
            else
            {
                int random = rand.Next(possibleValuesList.Count - 1);
                returnList.Add(possibleValuesList[random]);
                possibleValuesList.RemoveAt(random);
                return GenerateRandomNumbers(possibleValuesList,
                    numberOfNumbers, returnList);
            }
        }

        public List<int> GenerateRandomNumbers(List<int> possibleValuesList,
            int numberOfNumbers)
        {
            List<int> returnList = new List<int>();
            if (returnList.Count == numberOfNumbers)
            {
                return returnList;
            }
            else
            {
                int random = rand.Next(possibleValuesList.Count - 1);
                returnList.Add(possibleValuesList[random]);
                possibleValuesList.RemoveAt(random);
                return GenerateRandomNumbers(possibleValuesList,
                    numberOfNumbers, returnList);
            }
        }
    }
}
