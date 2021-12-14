# SageHenderson_launchpad_backend_codechallenge
The final code challenge in the LaunchPad program.

This project is an ASP.NET Core Web Application and was made in ASP.NET 5.0, in Visual Studio 2019.

To use this code simply clone the repository into your Visual Studio 2019 and select the branch/feature you wish to check the code from. 

The startup project should be Docker Compose for Questions 2 through 6. For Question 7 use Question7Project and for Question 8 use Questoin8Project.



The Requirements of this code challenge are below:

1. Start an empty solution. Create an ASP.NET Core Web Application. Choose ASP.NET Core 5.0 and API for the
template of the project. Configure for HTTPS on the API project.

Follow the given patterns to name the solution: <<yourname>>_launchpad_backend_codechallenge
Follow the given patterns to name the project: LaunchpadCodeChallenge.API


2. Prepare a supporting architecture (classes/entities) for the following situation, keeping reusability in mind.
We have an application that requires to show the list of departments in a company to the company manager.

• Each department will have a name and a unique address.
• Departments consist of employees.
• Employees will have first name, last name, job title and address of residence (mailing address).
** You are not required to break the address down to the country, province city level. An address field is enough for the code challenge purpose.


3. Define a service Implementation for the following:
For Employees we need to have these functionalities. The method signatures should be exactly the same as follows:

IEnumerable<Employee> GetAll()
IList<Employee> ListAll()

Since we are not using a database, provide 2-3 test data.


4. Provide a RESTful API controller for employees and provide these two endpoints.

GET api/employees
GET api/employees/department/{departmentId}

5. Add Docker and Docker Compose support to the solution and API project.


6. Imagine we are connected to the Database now. We’d like to switch from in Memory implementation of
Employee service to the database implementation. Suggest and apply a way to switch from your previous
implementation to the new one and consider the methods you implemented before.

IEnumerable<Employee> GetAll()
IList<Employee> ListAll()

** Database and Entity Framework implementation is not required.


7. Add a console project to the solution. Add this class to the console project.

public static class QuestionClass
{
 static List<string> NamesList = new List<string>()
 {
 "Jimmy",
 "Jeffrey",
 "John",
 };
}

Iterate through the NamesList items without using ForEach/For loops.


8. Create a method called TESTModule, this method simply is a method that we pass values to it and it returns the result. With one Switch Statement, cover the provided requirements.

a. For integer values of 1,2,3,4 multiply the provided value by 2 and return the result.
b. For any integer value bigger than 4, multiply the provided value by 3 and return the result.
c. For integer values below 1, throw proper exception.
d. For float values of 1.0f and 2.0f return 3.0f.
e. For any string values convert them to UpperCase.
f. For anything else, return the input value itself.


9. Add an AWS Lambda Project to the solution, write a simple lambda to catch DynamoDbEvent, Debug/Mock
the lambda function, log (console log) the Id of updated DynamoDb entries.
