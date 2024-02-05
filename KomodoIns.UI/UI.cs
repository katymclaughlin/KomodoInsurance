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
            Console.WriteLine("Developer Name          | ID       ");
            Console.WriteLine("===================================");
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
            Console.WriteLine("We have added the developer " + addDeveloperInput + " " + "with an ID of " );
            NewDeveloper.Name = addDeveloperInput;
            bool AddDeveloperToList = developerList.AddDeveloperToList(NewDeveloper);
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
            Console.WriteLine("B. List of Developers");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("C. List of Developers with Pluralsight License");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("D. List of Developers who need a Pluralsight License");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("E. Update a Developer");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("F. Delete a Developer");

//NOTE - Create/Read/Update/Delete Teams
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("TEAM OF DEVELOPERS");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("E. Create a new team");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("F. List of Teams");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("G. Update a Team");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("H. Delete a team");
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
                case "x":
                    return;
                    break;
                }
            }
        }
    }
}

//NOTE - Get a list of all Developers that need a Pluralsight license
//NOTE - Add to team requirement
//NOTE - Should be able to see a list of existing developers to choose from and add to existing teams
//NOTE - Managers will create a team
//NOTE - Add developers individually from the Developer Directory to that team
//NOTE - Challenge: multi-select add - add multiple develoeprs to a team at once