//Using statements 

using System;
using System.IO;
using System.Collections.Generic;

//Namespace
namespace SampleNamespace
{
//Class declaration
    class Program
    {
    //function declaration
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // Person newGuy = new Person();
            // newGuy.Introduce();

            // Person someOtherPerson = new Person("Tommy", "Nguyen");
            // someOtherPerson.Introduce();

            // Console.WriteLine(newGuy.getFirstName());
            // newGuy.setFirstName("Stefan");
            // Console.WriteLine(newGuy.getFirstName());

            // Employee Kyler = new Employee(40, 18.50, "Kyler", "Dennis");
            // Kyler.doWork();
            // Kyler.Introduce();
            // Console.WriteLine();

            // Employee Sam = new Employee();
            // Sam.setPayRate(20.00);
            // Sam.setHoursWorked(30);
            // Sam.setFirstName("Sam");
            // Console.WriteLine(
            //     Sam.getFirstName() + " has worked " +  Sam.getHoursWorked()
            //     + " hours at a pay rate of $" + Sam.getPayRate() + " per hour.");
            // Console.WriteLine();
            
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // Trainee Melinda = new Trainee();
            // Melinda.doWork();
            // Melinda.setFirstName("Melinda");
            // Melinda.Introduce();
            // Console.WriteLine(Melinda.getInTraining());
            // Console.WriteLine();

            // Customer Howard = new Customer(200, "Howard", "Wen");
            // Howard.Introduce();
            // Console.WriteLine(Howard.CashOnHand);
            // Console.WriteLine();

            // FullTimeEmployee Tim = new FullTimeEmployee();
            // Tim.setFirstName("Tim");
            // Tim.setLastName("Hall");
            // Tim.Introduce();
            // Console.WriteLine("I am full time? " + Tim.IsFullTime);
            // Console.WriteLine();

            // Child Suzi = new Child();
            // Suzi.setFirstName("Suzi");
            // Suzi.setLastName("Hall");
            // Suzi.Introduce();
            // Console.WriteLine("Do I have a job? " + Suzi.HasAJob);
            // Console.WriteLine("Am in school? " + Suzi.GoToSchool);
            // Console.WriteLine("I am " + Suzi.Age + " years old.");
            // Console.WriteLine("I am in " + Suzi.InGrade + " grade.");
            // Console.WriteLine();

            // Child Max = new Child(7, 2, "Max", "Hall");
            // Max.Introduce();
            // Console.WriteLine("Do I have a job? " + Max.HasAJob);
            // Console.WriteLine("Am in school? " + Max.GoToSchool);
            // Console.WriteLine("I am " + Max.Age + " years old.");
            // Console.WriteLine("I am in " + Max.InGrade + " grade.");
            // Console.WriteLine();

            DerivedChild Max = new DerivedChild();
            Max.FirstName = "Max";
            Max.LastName = "Hall";
            Max.Introduce();
            Max.Action();
        }
    }
}