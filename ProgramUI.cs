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
            Console.WriteLine("**************************************");
            Console.WriteLine("**                                  **");
            Console.WriteLine("**         Komodo Insurance         **");
            Console.WriteLine("**     Developer Team Management    **");
            Console.WriteLine("**                                  **");
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

            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
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

            int userInput = Int32.Parse(Console.ReadLine());
        }
        private void ManageTeamsMenu()
        {

        }
        private void HrMenu()
        {

        }
    }
}
