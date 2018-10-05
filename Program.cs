using System;
using System.Collections.Generic;

// There are 3 classes that need to be created for this to happen
// 1. Employee
// 2. Company
// 3. Program... the main one with the info
public class Employee
{

    // Some readonly properties (let's talk about gets, baby)
    public string firstName { get; set;}
    public string lastName { get; set;}
    public string title { get; set;}
    public DateTime startDate { get; set;}

public Employee (string FirstName, string LastName, string Title, DateTime StartDate) {
            firstName = FirstName;
            lastName = LastName;
            title = Title;
            startDate = StartDate;
        }

}

public class Company
{

    // Some readonly properties (let's talk about gets, baby)
    public string name { get; set;}
    public DateTime createdOn { get; set;}

    // Create a public property for holding a list of current employees
     public List<Employee> EmployeeList = new List<Employee>();

   /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    public Company (string CompanyName, DateTime CreatedOn){
        name = CompanyName;
        createdOn = CreatedOn;
    }

    // This will write it in the console
     public void ListEmployees(){
        foreach (Employee person in EmployeeList)
        {
            Console.WriteLine($"{person.firstName} {person.lastName} known for {person.title} since {person.startDate}");
        }}
}


// This class has all the hard info that fills the console
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.
         Company BloopBlaap = new Company( "BloopBlaap", DateTime.Now);
        // Create three employees
        Employee RiKiKi = new Employee ("RiKiKi", "don't you love me", "2nd best", DateTime.Now);
        Employee Alejandro = new Employee ("Alejandro", "Font", "bootay stankin'", DateTime.Now);
        Employee Madi = new Employee ("Modal", "Madi", "the modal-yodel", DateTime.Now);
        // Create a list for employees
    List<Employee> employees = new List<Employee> ();

        // add employees to the employees list
        employees.Add (RiKiKi);
        employees.Add (Alejandro);
        employees.Add (Madi);
        // make employees and bloopblaap fill the informtaion of the EmployeeList function.
        BloopBlaap.EmployeeList = employees;

        // call the EmployeeList function
        BloopBlaap.ListEmployees();

        // call in console to get response.

    }
}
