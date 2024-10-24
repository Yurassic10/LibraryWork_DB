using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLibrary.EditorHelper
{
    public class MenuConsole
    {
        public static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("\nMain menu:"
                + "\n1. Do actions with Author"
                + "\n2. Do actions with Book"
                + "\n3. Do actions with Client"
                + "\n4. Do actions with Genre"
                + "\n5. Do actions with Hall"
                + "\n6. Do actions with Staff"
                + "\n0. End the program.");
        }
        public static void ShowAuthorMenu()
        {
            Console.Clear();
            Console.WriteLine("\nAuthor menu:"
                + "\n1. See all Author."
                + "\n2. Add Author."
                + "\n3. Delete Author."
                + "\n4. Get Author by id."
                + "\n5. Back to main menu");
        }
        public static void ShowBookMenu()
        {
            Console.Clear();
            Console.WriteLine("\nBook menu:"
                + "\n1. See all Book."
                + "\n2. Add Book."
                + "\n3. Delete Book."
                + "\n4. Get Book by id."
                + "\n5. Back to main menu");
        }
        public static void ShowClientMenu()
        {
            Console.Clear();
            Console.WriteLine("\nClient menu:"
                + "\n1. See all Client."
                + "\n2. Add Client."
                + "\n3. Delete Client."
                + "\n4. Get Client by id."
                + "\n5. Back to main menu");
        }
        public static void ShowGenreMenu()
        {
            Console.Clear();
            Console.WriteLine("\nGenre menu:"
                + "\n1. See all Genre."
                + "\n2. Add Genre."
                + "\n3. Delete Genre."
                + "\n4. Get Genre by id."
                + "\n5. Back to main menu");
        }
        public static void ShowHallMenu()
        {
            Console.Clear();
            Console.WriteLine("\nHall menu:"
                + "\n1. See all Hall."
                + "\n2. Add Hall."
                + "\n3. Delete Hall."
                + "\n4. Get Hall by id."
                + "\n5. Back to main menu");
        }
        public static void ShowStaffMenu()
        {
            Console.Clear();
            Console.WriteLine("\nStaff menu:"
                + "\n1. See all Staff."
                + "\n2. Add Staff."
                + "\n3. Delete Staff."
                + "\n4. Get Staff by id."
                + "\n5. Back to main menu");
        }
    }
}
