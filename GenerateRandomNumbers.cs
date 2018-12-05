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

        //This is the private method for GenerateRandomNumbers that is only called upon in the
        //body of the public method.  It takes an additional parameter of a list with integer values
        //that will be returned.
        private List<int> GenerateRandomNumbers(List<int> possibleValuesList,
            int numberOfNumbers, List<int> returnList)
        {
            if (returnList.Count == numberOfNumbers) //all the numbers have been generated
            {
                return returnList; //return the list of random numbers
            }
            else
            {
                //create a random number that can be any index of the possibleValuesList
                int random = rand.Next(possibleValuesList.Count - 1);
                //add the value of possibleValuesList at index random to the return list
                returnList.Add(possibleValuesList[random]);
                //remove the value of the possibleValuesList at index random
                possibleValuesList.RemoveAt(random);
                //call the method again, passing as arguments the new lists for possible values
                //and return values as well as the number of numbers wanting to be generated
                return GenerateRandomNumbers(possibleValuesList,
                    numberOfNumbers, returnList);
            }
        }

        //This method is the public method that takes parameters for a list of possible values
        //wanted to generate and an integer for the number of numbers wanted to be generated
        //This method does not return any number in the list of possible values twice.
        //The count of the list of possible values must be at least the number of numbers
        //wanted to be generated.
        public List<int> GenerateRandomNumbers(List<int> possibleValuesList,
            int numberOfNumbers)
        {
            List<int> returnList = new List<int>(); //create return list
            //if number of numbers = (0) or the count of the list of possible values < number of numbers
            if (returnList.Count == numberOfNumbers || possibleValuesList.Count < numberOfNumbers)
            {
                return returnList; //returns an empty list
            }
            else
            {
                //create a random number that can be any index of the possibleValuesList
                int random = rand.Next(possibleValuesList.Count - 1);
                //add the value of possibleValuesList at index random to the return list
                returnList.Add(possibleValuesList[random]);
                //remove the value of the possibleValuesList at index random
                possibleValuesList.RemoveAt(random);
                //call the method again but passing the return list as an argument as well
                return GenerateRandomNumbers(possibleValuesList,
                    numberOfNumbers, returnList);
            }
        }
    }
}
