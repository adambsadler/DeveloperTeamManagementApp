using DevTeamRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeamManagementApp
{
    class ProgramUI
    {
        public void Run()
        {
            MainMenu();
        }

        private void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("**************************************");
            Console.WriteLine("*****                            *****");
            Console.WriteLine("***        Komodo Insurance        ***");
            Console.WriteLine("**     Developer Team Management    **");
            Console.WriteLine("***                                ***");
            Console.WriteLine("**************************************");
            Console.WriteLine("Welcome! Please select from the options below:\n" +
                "1. Manage Developers\n" +
                "2. Manage Teams\n" +
                "3. HR Reporting Tool\n" +
                "4. Exit");

            string userInput = Console.ReadLine();
            bool validInput = false;
            while (validInput == false)
            {
                switch (userInput)
                {
                    case "1":
                        validInput = true;
                        ManageDevelopersMenu();
                        break;
                    case "2":
                        validInput = true;
                        ManageTeamsMenu();
                        break;
                    case "3":
                        validInput = true;
                        HrMenu();
                        break;
                    case "4":
                        validInput = true;
                        Console.Clear();
                        Console.WriteLine("Thank you for using the Developer Team Management Application.");
                        Console.WriteLine("Developed by Adam Sadler");
                        Console.WriteLine("Please press any key to continue...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please Select a valid option.\n" +
                            "1. Manage Developers\n" +
                            "2. Manage Teams\n" +
                            "3. HR Reporting Tool\n" +
                            "4. Exit");
                        userInput = Console.ReadLine();
                        break;
                }
            }
        }

        private void ManageDevelopersMenu()
        {
            Console.Clear();
            Console.WriteLine("Please choose from the options below:\n" +
                 "1. Create A New Developer\n" +
                 "2. Display All Developers\n" +
                 "3. Update Developer Information\n" +
                 "4. Remove A Developer\n" +
                 "5. Back to Main Menu");

            string userInput = Console.ReadLine();
            bool validInput = false;
            while(validInput == false)
            {
                switch(userInput)
                {
                    case "1":
                        validInput = true;
                        CreateNewDeveloper();
                        break;
                    case "2":
                        validInput = true;

                        break;
                    case "3":
                        validInput = true;

                        break;
                    case "4":
                        validInput = true;

                        break;
                    case "5":
                        validInput = true;
                        MainMenu();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please Select a valid option.\n" +
                            "1. Create a New Developer\n" +
                            "2. Display All Developers\n" +
                            "3. Update Developer Information\n" +
                            "4. Remove A Developer\n" +
                            "5. Back to Main Menu");
                        userInput = Console.ReadLine();
                        break;

                }
            }
        }
        private void ManageTeamsMenu()
        {

        }
        private void HrMenu()
        {

        }

        private void CreateNewDeveloper()
        {
            Console.Clear();
            Developer newDeveloper = new Developer();

            Console.WriteLine("Enter the first name of the developer:");
            newDeveloper.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the last name of the developer:");
            newDeveloper.LastName = Console.ReadLine();

            Console.WriteLine("Does this developer have access to Pluralsight? (y/n)");
            string userInput = Console.ReadLine();
            bool validInput = false;
            while(validInput == false)
            {
                switch(userInput)
                {
                    case "y":
                        validInput = true;
                        newDeveloper.HasPluralsightAccess = true;
                        break;
                    case "n":
                        validInput = true;
                        newDeveloper.HasPluralsightAccess = false;
                        break;
                    default:
                        Console.WriteLine("Please enter y or n.");
                        userInput = Console.ReadLine();
                        break;
                }
            }
        }
    }
}
