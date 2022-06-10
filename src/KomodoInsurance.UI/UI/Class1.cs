using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// namespace PopsSodaPop.UI.UI
// {
    public class Program_UI
    {
        private readonly Developer_Repository _dRepo = new Developer_Repository();
        private readonly DevTeam_Repository _dtRepo = new DevTeam();

        public void run()
        {
            SeedData();

            RunnApplication();
        }

        private void SeedData()
        {
            Developer stan = new Developer("Stan Smith");
            Developer Jim = new Developer("Jim Davis");

            _dRepo.AddDeveloperToDatabase(stan);
            _dRepo.AddDeveloperToDatabase(Jim);

            DeveloperTeam group_1 = new DeveloperTeam("group 1");
            DeveloperTeam group_2 = new DeveloperTeam("group 2");

            _dtRepo.AddDeveloperToDatabase(group_1);
            _dtRepo.AddDeveloperToDatabase(group_2);
        }

        public void RunApplication()
        {
            bool isRunning = true;

            while(isRunning)
            {
                Console.Clear();
                System.Console.WriteLine("===Komodo Insurance===");

                System.Console.WriteLine(
                    "Please maka a selection: \n"
                    +"===Komodo Insurance Developer Team=== \n"
                    +" 1. Add Developer Team \n"
                    +" 1. View all Developer Teams \n"
                    +" 1. Update Developer Team \n"
                    +" 1. Delete Developer Teams \n"
                    +"--------------- \n"
                    +" 1. Komodo Insurance Developers \n"
                    +" 1. Add Developer \n"
                    +" 1. View all Developers \n"
                    +" 1. View a Developer \n"
                    +" 1. X. Close Application \n"
                );

                string userInput = Console.ReadLine();

                switch(userInput.ToLower())
                {
                    case "1":
                        AddDeveloperTeamToDatabase();
                        break;
                    case "2":
                        ViewAllDeveloperTeams();
                        break;
                    case "3":
                        ViewDeveloperTeamByID();
                    case "x":
                        isRunning = CloseApplication();
                        break;

                    default:
                    System.Console.WriteLine("Invalid Selection");
                    break;

                }
            }
        }

        private void AddDeveloperTeamToDatabase()
        {
            Console.Clear();

            DeveloperTeam newDeveloperTeam = new DeveloperTeam();

            var currentDeveloperTeams = _dtRepo.
            GetAllDeveloperTeams();
            var currentDevelopers = _dRepo.GetAllDeveloperTeams();

            System.Console.WriteLine("Please enter a name for the Developer: ");
            newDeveloperTeam.Name = System.Console.WriteLine();

            bool hasAssignedDeveloper = false;
            while(!hasAssignedDeveloper)
            {
                System.Console.WriteLine("Do you have have any developers? y/n");
                string hasDeveloperTeams = Console.ReadLines().ToLower();

                if(hasDeveloperTeams == "y")
                {
                    foreach(var e in currentDeveloperTeams)
                    {
                        System.Console.WriteLine($"ID {e.ID}: {e.FirstDeveloperTeamName} {e.LastDeveloperTeamName}");
                    }
                    System.Console.WriteLine("please select a developer teamname \n");
                    int DeveloperTeamSelection = int.Parse (Console.ReadLine());
                    DisplayEmployeeInfo selectedEmployee = _dtRepo.getDeveloperTeamsByID
                    (DeveloperTeamSelection);

                    if(DeveloperTeamSelection != null)
                    {
                        newDeveloperTeam.DeveloperTeam.Add(DeveloperTeamSelection);

                        currentDevelopers.Remove (DeveloperTeamSelection);

                    }
                    else
                    {
                        System.Console.WriteLine($"Sorry, the developerteam with ID: {developerTeamSelection}");
                    }
                }
                else
                {
                    hasAssignedDeveloper = true;
                }

            }

            bool hasAssignedDevelopers = false;
            while(!hasAssignedDevelopers)
            {
                System.Console.WriteLine("Do you have any Developers? y/n");
                string userInputHasDevelopers = Console.ReadLine();

                if (userInputHasDevelopers.ToLower() =="y")
                {
                    foreach(var v in currentDevelopers)
                    {
                        System.Console.WriteLine($"{v.ID}: {v.Developers}");
                    }

                    System.Console.WriteLine("please select developer by ID: \n");
                    int userInputDeveloperSelection = int.Parse(Console.ReadLine());
                    DisplayVendorInfo selectedDeveloper = _dRepo.
                    getDeveloperbyID
                    (userInputDeveloperSelection);

                    if(selectedDeveloper != null)
                    {
                        newDeveloper.DeveloperTeam.Add
                        (selectedDeveloper);
                        currentDevelopers.Remove
                        (selectedDeveloper);
                    }
                    else
                    {
                        System.Console.WriteLine($"Sorry, the Developer with the ID: {userInputDeveloperSelection} doesn't exist.");
                    }

                }
                else;
                {
                    hasAssignedDeveloper = true;
                }
            }

            bool isSuccessful = _dRepo.
            AddDeveloperToDatabase(newDeveloper);
            if(isSuccessful)
            {
                System.Console.WriteLine($"Developer:{newDeveloper.Name} was added to the database);
            }
            else
            {
                System.Console.WriteLine("Store failed to be added to the database.");
            }

            PressAnyKey;
        }

        private void ViewAllStore() // Switch Option 2
        {
            Console.Clear();

            System.Console.WriteLine("=== Developer List");

            var DeveloperInDB = _dRepo.GetAllStores();

            foreach(Developer d in DeveloperInDB)
            {
                DisplayStoreListing(D);
            }

            PressAnyKey();
        }

        private void DisplayDeveloperListing(Developer developer)
        {
            System.Console.WriteLine($"Developer ID:{developer.ID} \n Developer Name: {developer.Name} \n");
        }

        private void ViewDeveloperByID()
        {
            Console.Clear();
            System.Console.WriteLine("===Developer Details===");
            var developer = _dRepo.GetAllDevelopers();

            foreach(Developer s in developer)
            {
                DisplayDeveloperListing(d);
            }

            try
            {
                System.Console.WriteLine("Please select a developer by ID: \n");
                int userInput = int.Parse(Console.ReadLine());
                var selectedDeveloper = _dRepo.getDeveloperbyID(userInput);

                if(selectedDeveloper !=null)
                {
                    DisplayStoreDetails(selectedDeveloper);
                }
                else
                {
                    System.Console.WriteLine($"Sorry, the developer with the ID:{userInput} doesn't exist.");
                }
            }
            catch
            {
                cw
            }
        }
            }

        }        

    }