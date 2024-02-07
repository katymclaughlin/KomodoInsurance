using System.Data.Common;
using KomodoIns.Data;
using KomodoIns.Repository;

namespace Komodo_UI
{
        public class UIHelper
        {
        DeveloperRepo developerList = new DeveloperRepo();
        DevTeamRepo devTeamList = new DevTeamRepo();
        
        public void ListofDevelopers()
        {
            List<Developer> DeveloperList = developerList.GetDeveloperList();
            Console.WriteLine ("Developer List Amount = " + DeveloperList.Count);
            Console.WriteLine("Developer Name                 | ID       ");
            Console.WriteLine("==========================================");
            for (int i = 0; i < DeveloperList.Count; i++ )
            {
            Console.WriteLine(DeveloperList[i].Name + "                " + DeveloperList[i].Id + "              ");
            }
        }
        
        public void AddDeveloper()
        {
            Developer NewDeveloper = new Developer();
            Console.WriteLine("Please type the first and last name for the developer you would like to add.");
            string addDeveloperInput = Console.ReadLine();
            Guid g = Guid.NewGuid();
            Console.WriteLine("Type 1 if the Developer has a PluralSight License.");
            Console.WriteLine("Type 2 if the Developer does not have a PluralSight License.");
            int addDeveloperInput2 = Convert.ToInt32(Console.ReadLine());
                if (addDeveloperInput2 == 2)
                {
                    NewDeveloper.HasPluralsight = false;
                    Console.WriteLine ("The developer does not have a PluralSight License.");
                }
                else
                {
                    NewDeveloper.HasPluralsight = true;
                    Console.WriteLine ("The developer does have a PluralSight License.");
                }
            Console.WriteLine("We have added the developer " + addDeveloperInput + " " + "with an ID of " + g );
            NewDeveloper.Name = addDeveloperInput;
            NewDeveloper.Id = g;
            bool AddDeveloperToList = developerList.AddDeveloperToList(NewDeveloper);
        }

//NOTE - Get a list of all Developers that need a Pluralsight license
        public void NeedPluralSight()
        {
            List<Developer> DeveloperList = developerList.GetDeveloperList();
             for (int p = 0; p < DeveloperList.Count; p++)
             {
                if (DeveloperList[p].HasPluralsight == false)
                {
                    Console.WriteLine (DeveloperList[p].Name);
                }
             }   
        }

        public void UpdateDeveloper ()
        {
            Console.WriteLine ("Please type the number next to the developer you would like to update.");
            List<Developer> DeveloperList = developerList.GetDeveloperList();
            for (int i = 0; i < DeveloperList.Count; i++ )
            {
                Console.WriteLine(i + " " + DeveloperList[i].Name);
            }
            int updateUserInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide the new developer name:");
            string updateDeveloper2 = Console.ReadLine();
            bool UpdateExistingDeveloper = developerList.UpdateExistingDeveloper(updateUserInput, updateDeveloper2);
           
        }

        public void DeleteDevelopers()
        {
            Console.WriteLine("Please type the number next to the developer you would like to delete.");
            List<Developer> DeveloperList = developerList.GetDeveloperList();
            for (int i = 0; i < DeveloperList.Count; i++)
            {
                Console.WriteLine(i + " " + DeveloperList[i].Name);
            }
            int deleteUserInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Deleting Developer # " + deleteUserInput);
            bool DeleteDeveloperbyId = developerList.RemoveDeveloperFromList(deleteUserInput);
        }

//NOTE - Managers will create a team
        public void CreateATeam()
        {
            DevTeam NewTeam = new DevTeam();
            Console.WriteLine("Please type the name for this new team.");
            string addTeamInput = Console.ReadLine();
            Console.WriteLine("Please type the id for this new team.");
            string addTeamInput2 = Console.ReadLine();
            NewTeam.TeamName = addTeamInput;
            NewTeam.TeamId = Convert.ToInt32(addTeamInput2);
            bool AddTeam = devTeamList.CreateTeam(NewTeam);
            Console.WriteLine("Adding the " + addTeamInput + " group with ID " + addTeamInput2 + " to our Team Directory");

        }
        
        public void ListofTeams()
        {

        }

//NOTE - Should be able to see a list of existing developers to choose from and add to existing teams
//NOTE - Challenge: multi-select add - add multiple develoeprs to a team at once
        public void UpdateTeam()
        {

        }

        public void DeleteTeam()
        {

        }

        }

        
        public class UIKomodoInsurance
        {
        public static void Main(string[] args)
        {
            UIHelper uih = new UIHelper();
            while (true)
            {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ");
            Console.WriteLine("--> KOMODO INSURANCE DEVELOPER TEAM MANAGEMENT APPLICATION <--");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==============================================================");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("How can we help you manage your software development teams?");
            Console.WriteLine(" ");

//NOTE - Create/Read/Update/Delete/Developers
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("INDIVIDUAL DEVELOPERS");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("A. Add a Developer");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("B. List of Developers with ID");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("C. List of Developers who need a Pluralsight License");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("D. Update a Developer");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("E. Delete a Developer");

//NOTE - Create/Read/Update/Delete Teams
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("TEAM OF DEVELOPERS");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("F. Create a new team");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("G. List of Teams");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("H. Update a Team");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("I. Delete a team");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("EXIT");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("X. EXIT THE APPLICATION");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==============================================================");
    
//NOTE - Application display page with options for user
            string menuUserInput = Console.ReadLine().ToLower();
            //Console.WriteLine("menu input = "+menuUserInput);
            switch(menuUserInput)
                {
                case "a":
                    uih.AddDeveloper();
                    break;
                case "b":
                    uih.ListofDevelopers();
                    break;
                case "c":
                    uih.NeedPluralSight();
                    break;
                case "d":
                    uih.UpdateDeveloper();
                    break;
                case "e":
                    uih.DeleteDevelopers();
                    break;
                case "f":
                    uih.CreateATeam();
                    break;
                case "g":
                    uih.ListofTeams();
                    break;
                case "h":
                    uih.UpdateTeam();
                    break;
                case "i":
                    uih.DeleteTeam();
                    break;
                case "x":
                    return;
                    break;
                }
            }
        }
    }
}


