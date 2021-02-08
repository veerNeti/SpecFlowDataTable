using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowDataTable.Steps
{
    [Binding]
    public class DataTableSteps
    {

        [Given(@"I entered the following data into the new account form horizontal using the section")]
        public void GivenIEnteredTheFollowingDataIntoTheNewAccountFormHorizontalUsingTheSection(Table table)
        {
            IEnumerable<Person> enumerable = table.CreateSet<Person>(); // read entire table into collection of objects
            IEnumerator<Person> enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {

                Console.WriteLine("Name:\t" + enumerator.Current.Name +
                    "\nHeightInInches:\t" + enumerator.Current.HeightInInches+
                    "\nBirthdate:\t" + enumerator.Current.Birthdate+
                    "\nBankAccountBalance:\t" + enumerator.Current.BankAccountBalance+
                "\n---------------------------------------------------------- \n");
            }
        }
        
        [Given(@"I entered the following data into the new account form horizontal using modal")]
        public void GivenIEnteredTheFollowingDataIntoTheNewAccountFormHorizontalUsingModal(Table table)
        {
            Person person = table.CreateInstance<Person>();
            Console.WriteLine("name:\t" + person.Name +
                "\nbirthDate:\t" + person.Birthdate
                + "\nheightInInches:\t" + person.HeightInInches
                + "\nbankAccountBalance:\t" + person.BankAccountBalance + "\n---------------------------------------------------------- \n");

        }

        [Given(@"I entered the following data into the new account form horizontal using tuple")]
        public void GivenIEnteredTheFollowingDataIntoTheNewAccountFormHorizontalUsingTuple(Table table)
        {
            var person = table.CreateInstance<(string name, string birthDate, int heightInInches, decimal bankAccountBalance)>();  //using tuple

            Console.WriteLine("name:\t" + person.name +
                "\nbirthDate:\t" + person.birthDate
                + "\nheightInInches:\t" + person.heightInInches
                + "\nbankAccountBalance:\t" + person.bankAccountBalance + "\n---------------------------------------------------------- \n");

        }

        [Given(@"I entered the following data into the new account form vertical")]
        public void GivenIEnteredTheFollowingDataIntoTheNewAccountFormVertical(Table table)
        {
            Person person = table.CreateInstance<Person>();// read each single row
            Console.WriteLine("name:\t" + person.Name +
                "\nbirthDate:\t" + person.Birthdate
                + "\nheightInInches:\t" + person.HeightInInches
                + "\nbankAccountBalance:\t" + person.BankAccountBalance + "\n---------------------------------------------------------- \n");

        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string HeightInInches { get; set; }
        public string BankAccountBalance { get; set; }
    }

    class Account
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    }
}
