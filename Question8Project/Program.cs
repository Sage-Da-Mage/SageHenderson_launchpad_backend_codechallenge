using System;

namespace Question8Project
{
    class Program
    {
        public static object TESTModule(object inputObject)
        {
            // Set an object that we can use to return values depending on what cases the switch lands in
            object result;

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
