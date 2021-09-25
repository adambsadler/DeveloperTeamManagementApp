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
        private DeveloperRepo _developerRepo = new DeveloperRepo();
        private DevTeamRepo _devTeamRepo = new DevTeamRepo();
        public void Run()
        {
            SeedDevTeamList();
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
                        Console.WriteLine("Please press any key to close the program.");
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
                        DisplayAllDevelopers();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        ManageDevelopersMenu();
                        break;
                    case "3":
                        validInput = true;
                        UpdateDeveloperInfo();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        ManageDevelopersMenu();
                        break;
                    case "4":
                        validInput = true;
                        RemoveDeveloper();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        ManageDevelopersMenu();
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
            Console.Clear();
            Console.WriteLine("Please choose from the options below:\n" +
                 "1. Create A New Team\n" +
                 "2. Display All Teams\n" +
                 "3. Update Team Name\n" +
                 "4. Assign Developers to Team\n" +
                 "5. Remove Developers From Team\n" +
                 "6. Back to Main Menu");

            string userInput = Console.ReadLine();
            bool validInput = false;
            while(validInput == false)
            {
                switch(userInput)
                {
                    case "1":
                        validInput = true;
                        CreateNewTeam();
                        break;
                    case "2":
                        validInput = true;
                        DisplayAllTeams();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        ManageTeamsMenu();
                        break;
                    case "3":
                        validInput = true;
                        UpdateTeamInfo();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        ManageTeamsMenu();
                        break;
                    case "4":
                        validInput = true;
                        AssignDeveloperToTeam();
                        Console.WriteLine("Assignment complete. Press any key to continue...");
                        Console.ReadKey();
                        ManageTeamsMenu();
                        break;
                    case "5":
                        validInput = true;
                        RemoveDeveloperFromTeam();
                        Console.WriteLine("Developers removed. Press any key to continue...");
                        Console.ReadKey();
                        ManageTeamsMenu();
                        break;
                    case "6":
                        validInput = true;
                        MainMenu();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please Select a valid option.\n" +
                            "1. Create a New Team\n" +
                            "2. Display All Teams\n" +
                            "3. Update Team Name\n" +
                            "4. Assign Developers to Team\n" +
                            "5. Remove Developers From Team\n" +
                            "6. Back to Main Menu");
                        userInput = Console.ReadLine();
                        break;
                }
            }
        }
        private void HrMenu()
        {
            Console.Clear();
            Console.WriteLine("This is the monthly report showing all developers who need Pluralsight access:");
            List<Developer> listOfDevelopers = _developerRepo.GetDeveloperList();
            
            foreach(Developer developer in listOfDevelopers)
            {
                if(developer.HasPluralsightAccess == false)
                {
                    Console.WriteLine($"First Name: {developer.FirstName}\n" +
                        $"Last Name: {developer.LastName}\n" +
                        $"ID: {developer.IdNumber}\n" +
                        $"----------------------------------");
                }
            }

            Console.WriteLine("More features coming soon!");
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
            MainMenu();
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
            string userInput = Console.ReadLine().ToLower();
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

            _developerRepo.AddDeveloperToList(newDeveloper);
            Console.WriteLine($"{newDeveloper.FirstName} {newDeveloper.LastName} has been added as a new developer.");
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
            MainMenu();
        }

        private void CreateNewTeam()
        {
            Console.Clear();
            DevTeam newDevTeam = new DevTeam();

            Console.WriteLine("Enter the name of the new team:");
            newDevTeam.TeamName = Console.ReadLine();

            _devTeamRepo.AddTeamToList(newDevTeam);
            Console.WriteLine($"The new team named {newDevTeam.TeamName} has be created.");
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
            MainMenu();
        }

        private void DisplayAllDevelopers()
        {
            Console.Clear();
            List<Developer> listOfDevelopers = _developerRepo.GetDeveloperList();
            
            foreach(Developer developer in listOfDevelopers)
            {
                Console.WriteLine($"First Name: {developer.FirstName}\n" +
                    $"Last Name: {developer.LastName}\n" +
                    $"ID: {developer.IdNumber}\n" +
                    $"----------------------------------");
            }
        }

        private void DisplayAllTeams()
        {
            Console.Clear();
            List<DevTeam> listOfTeams = _devTeamRepo.GetTeamList();
            
            foreach(DevTeam devTeam in listOfTeams)
            {
                List<Developer> listOfMembers = _devTeamRepo.GetTeamMembers(devTeam);
                Console.WriteLine($"Team Name: {devTeam.TeamName}\n" +
                    $"Team ID: {devTeam.TeamId}\n" +
                    $"----------Team Members----------");
                foreach(Developer developer in listOfMembers)
                {
                    Console.WriteLine($"{developer.FirstName} {developer.LastName}");
                }
                Console.WriteLine("-------------------------------");
            }
        }

        private void UpdateDeveloperInfo()
        {
            DisplayAllDevelopers();

            Console.WriteLine("Enter the ID of the developer to update:");

            int oldDeveloper = Int32.Parse(Console.ReadLine());

            Developer newDeveloper = new Developer();

            Console.WriteLine("Enter the first name of the developer:");
            newDeveloper.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the last name of the developer:");
            newDeveloper.LastName = Console.ReadLine();

            Console.WriteLine("Does this developer have access to Pluralsight? (y/n)");
            string userInput = Console.ReadLine().ToLower();
            bool validInput = false;
            while (validInput == false)
            {
                switch (userInput)
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

            bool wasUpdated = _developerRepo.UpdateDeveloperInfo(oldDeveloper, newDeveloper);

            if(wasUpdated)
            {
                Console.WriteLine("The information for this developer has been updated.");
            }
            else
            {
                Console.WriteLine("We could not update this information. Please try again.");
            }
        }

        private void UpdateTeamInfo()
        {
            DisplayAllTeams();

            Console.WriteLine("Enter the ID of the team to update:");

            int oldTeam = Int32.Parse(Console.ReadLine());

            DevTeam newDevTeam = new DevTeam();

            Console.WriteLine("Enter the new name for this team:");
            newDevTeam.TeamName = Console.ReadLine();

            bool wasUpdated = _devTeamRepo.UpdateTeamInfo(oldTeam, newDevTeam);

            if(wasUpdated)
            {
                Console.WriteLine("The team name was successfully updated.");
            }
            else
            {
                Console.WriteLine("The team name could not be updated. Please try again.");
            }
        }
        
        private void RemoveDeveloper()
        {
            DisplayAllDevelopers();

            Console.WriteLine("Enter the ID of the developer to remove:");
            int oldId = Int32.Parse(Console.ReadLine());

            bool wasRemoved = _developerRepo.RemoveDeveloperFromList(oldId);

            if(wasRemoved)
            {
                Console.WriteLine("The developer was successfully removed.");
            }
            else
            {
                Console.WriteLine("The developer could not be removed. Please try again.");
            }
        }

        private void AssignDeveloperToTeam()
        {
            Console.Clear();
            DisplayAllTeams();
            Console.WriteLine("Enter ID for the team to which you will be assigning members:");
            DevTeam chosenTeam = _devTeamRepo.FindTeamById(Int32.Parse(Console.ReadLine()));

            Console.Clear();
            DisplayAllDevelopers();
            Console.WriteLine("How many developers would you like to assign to a team?");
            int numberToAssign = Int32.Parse(Console.ReadLine());
            List<Developer> chosenDevelopers = new List<Developer>();
            while (numberToAssign > 0)
            {
                Console.WriteLine("Please enter the ID of the developer:");
                int chosenDeveloperID = Int32.Parse(Console.ReadLine());
                chosenDevelopers.Add(_developerRepo.FindDeveloperById(chosenDeveloperID));
                numberToAssign--;
            }

            _devTeamRepo.AddDeveloperToTeam(chosenDevelopers, chosenTeam);
        }

        private void RemoveDeveloperFromTeam()
        {
            Console.Clear();
            DisplayAllTeams();
            Console.WriteLine("Enter the ID for the team from which you will be removing members:");
            DevTeam chosenTeam = _devTeamRepo.FindTeamById(Int32.Parse(Console.ReadLine()));
            List<Developer> assignedMembers = _devTeamRepo.GetTeamMembers(chosenTeam);

            Console.Clear();
            foreach(Developer developer in assignedMembers)
            {
                Console.WriteLine($"First Name: {developer.FirstName}\n" +
                    $"Last Name: {developer.LastName}\n" +
                    $"ID: {developer.IdNumber}\n" +
                    $"----------------------------------");
            }
            Console.WriteLine("How many developers would you like to remove from this team?");
            int numberToRemove = Int32.Parse(Console.ReadLine());
            List<Developer> toBeRemoved = new List<Developer>();
            while (numberToRemove >0)
            {
                Console.WriteLine("Please enter the ID of the developer:");
                int chosenDeveloperID = Int32.Parse(Console.ReadLine());
                toBeRemoved.Add(_developerRepo.FindDeveloperById(chosenDeveloperID));
                numberToRemove--;
            }

            _devTeamRepo.RemoveDeveloperFromTeam(toBeRemoved, chosenTeam);
        }

        // Seed developers and team
        private void SeedDevTeamList()
        {
            Developer adamSadler = new Developer("Adam", "Sadler", true);
            Developer scottMcFall = new Developer("Scott", "McFall", false);

            _developerRepo.AddDeveloperToList(adamSadler);
            _developerRepo.AddDeveloperToList(scottMcFall);

            DevTeam teamAlpha = new DevTeam("Alpha");
            List<Developer> assignedDevelopers = new List<Developer>();
            assignedDevelopers.Add(adamSadler);

            _devTeamRepo.AddTeamToList(teamAlpha);
            _devTeamRepo.AddDeveloperToTeam(assignedDevelopers, teamAlpha);
        }
    }
}
