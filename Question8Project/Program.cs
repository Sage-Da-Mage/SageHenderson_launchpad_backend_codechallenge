using System;

namespace Question8Project
{
    class Program
    {
        // The method TESTModule takes in an input and gives an output based on the following requirements:
        /*
         *  a. For integer values of 1,2,3,4 multiply the provided value by 2 and return the result.
            b. For any integer value bigger than 4, multiply the provided value by 3 and return the result.
            c. For integer values below 1, throw proper exception.
            d. For float values of 1.0f and 2.0f return 3.0f.
            e. For any string values convert them to UpperCase.
            f. For anything else, return the input value itself.
         */
        public static object TESTModule(object inputObject)
        {
            // Set result to null so that it can be checked through the switch
            object result = null;

            // Begin the switch statement
            switch (inputObject)
            {
                // In the case where the input is between 1 and 4, double its value and return it
                case int n when (n >= 1 && n <= 4):
                    result = n * 2;
                    break;

                // When the input is an integer greater than 4, return its value threefold
                case int n when (n > 4):
                    result = n * 3;
                    break;

                // In the situation where the input is less than 1 throw an exception
                case int n when (n < 1):
                    throw new Exception("Numeric input should be higher than 1");

                // When the input is a float of 1.0 or 2.0 return 3.0
                case float n when (n == 1.0f || n == 2.0f):
                    result = 3.0f;
                    break;

                // When the input is a string, uppercase it and return the result
                case string itIsString:
                    result = itIsString.ToUpper();
                    break;
                
                // In all other circumstances, return what was passed in
                default:
                    result = inputObject;
                    break;
            }

            return result;
        }

        static void Main(string[] args)
        {

            object myInputObject = "Convert this string into uppercase letters";
            Console.WriteLine("The TESTModule will return a value depending on what you change myInputObject to be: the current input is: " + myInputObject + " and it's current output is: " + TESTModule(myInputObject));

        }
    }
}
