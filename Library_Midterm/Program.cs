using System;
using System.Collections.Generic;

namespace Library_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {


            DisplayMenu();
            while (true)
            {
                string selection = UserInput("Please select from the list of commands below: ");
                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Here is what we have in stock.");
                        DisplayBooks();
                        //Call methods in all of these cases
                        UserContinue();
                        break;
                    case "2":
                        DisplayAuthor();
                        string authorResponse = UserInput("Please pick an author.");
                        Console.WriteLine(GetAuthor(authorResponse));
                        //display books by authors
                        UserContinue();
                        break;
                    case "3":
                        DisplayTitle();
                        UserContinue();
                        break;
                    case "4":
                        DisplayGenre();
                        string response = UserInput("Select a genre");
                        string userChoice = GetGenre(response);
                        DisplayBooksByGenre(userChoice);
                        UserContinue();
                        break;
                    case "5":
                        DisplayBooks();
                        string checkoutResponse = UserInput("Select what book you want to checkout? \n ");
                        int index = int.Parse(checkoutResponse) - 1;
                        Book.Books[index].CheckOut();
                        UserContinue();
                        //Take a book
                        break;
                    case "6":
                        DisplayBooks();
                        string checkinResponse = UserInput("Select what book you want to checkout? \n ");
                        int checkinIndex = int.Parse(checkinResponse) - 1;
                        Book.Books[checkinIndex].CheckIn();

                        UserContinue();
                        // Return Book
                        break;

                    case "7":
                        Environment.Exit(0);
                        //get kicked out of library
                        break;

                    default:
                        break;


                }

            }
        }

        public static string UserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;

        }
        public static void DisplayMenu()
        {
            Console.WriteLine("Hello, Welcome to Ody's Books!");
            Console.WriteLine("=============================");
            Console.WriteLine("[1]: Display All Books in Library");
            Console.WriteLine("[2]: Search Book by Author");
            Console.WriteLine("[3]: Search Book by Title");
            Console.WriteLine("[4]: Search Book Genre.");
            Console.WriteLine("[5]: Check Out Book");
            Console.WriteLine("[6]: Return Book");
            Console.WriteLine("[7]: Scream and get kicked out of the library.");
        }

        public static void DisplayBooks()
        {
            int count = 1;
            foreach (Book book in Book.Books)
            {
                Console.WriteLine();
                Console.WriteLine($"[{count}]Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Genre: {book.Genre}");

                if (book.Status == true)
                {
                    Console.WriteLine($"Status: Book is Available ");
                }
                else
                {
                    Console.WriteLine($" Status: book is Unavailable");
                  
                }
                count++;
            }



        }

        public static void DisplayAuthor()
        {
            List<string> authors = new List<string>();
            for (int i = 0; i < Book.Books.Count; i++)
            {
                if (!authors.Contains(Book.Books[i].Author))
                {
                    authors.Add(Book.Books[i].Author);
                }
            }
            int count = 1;
            foreach (string author in authors)
            {
                Console.WriteLine($"[{count}]{author}");
                count++;
            }
        }

        public static string GetAuthor(string authorResponse)
        {
            if (authorResponse == "1")
            {
                return "The Hobbit\n The Fellowship of The Ring\n The Twin Towers\n The Return of the Kin\n";
            }
            else if (authorResponse == "2")
            {
                return "Everybody Poops\n";
            }
            else if (authorResponse == "3")
            {
                return "The Theif of Always";
            }
            else if (authorResponse == "4")
            {
                return "Go the F*** to Sleep";
            }
            else if (authorResponse == "5")
            {
                return "Star Bellied Sneeches";
            }
            else if (authorResponse == "6")
            {
                return "The Dark Tower";
            }
            else if (authorResponse == "7")
            {
                return "Patroit Games, Rainbow Six, Red Rabbit";
            }
            else if (authorResponse == "8")
            {
                return "Pride and the Prejedice";
            }
            else if (authorResponse == "9")
            {
                return "Outlander";
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid selection.");
                Console.ResetColor();
                authorResponse = UserInput("Please select an Author: ");
                return GetAuthor(authorResponse);

            }
        }

        public static void DisplayTitle()
        {
            List<string> titles = new List<string>();
            for (int i = 0; i < Book.Books.Count; i++)
            {
                if (!titles.Contains(Book.Books[i].Title))
                {
                    titles.Add(Book.Books[i].Title);
                }
            }
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }

        }
        public static void DisplayGenre()
        {
            List<string> genres = new List<string>();
            foreach (Book book in Book.Books)
            {
                if (!genres.Contains(book.Genre))
                {
                    genres.Add(book.Genre);
                }
            }

            int count = 1;
            foreach (string genre in genres)
            {

                Console.WriteLine($"[{count}]: {genre}");
                count++;
            }
        }
        public static void DisplayBooksByGenre(string userChoice)
        {
            foreach (Book book in Book.Books)
            {
                if (book.Genre == userChoice)
                {
                    Console.WriteLine();
                    Console.WriteLine(book.Title);
                    Console.WriteLine(book.Author);
                    Console.WriteLine(book.Genre);

                    if (book.Status == true)
                    {
                        Console.WriteLine($"Status: Available ");
                    }
                    else
                    {
                        Console.WriteLine($" Status: Unavailable");
                    }


                }
            }




        }

        public static string GetGenre(string response)
        {
            if (response == "1")
            {
                return "Fantasy";
            }
            if (response == "2")
            {
                return "Childrens";
            }
            if (response == "3")
            {
                return "Thriller";
            }
            if (response == "4")
            {
                return "Romance";
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("invalid");
                Console.ResetColor();
                response = UserInput("Select a Genre");
                return GetGenre(response);
            }
        }

        public static string GetCheckout(string checkoutResponse)

        {
            if (checkoutResponse == "1")
            {
                return "The Hobbit";

            }
            else if (checkoutResponse == "2")
            {
                return "The Fellowship of The Ring";
            }
            else if (checkoutResponse == "3")
            {
                return "The Two Towers";
            }
            else if (checkoutResponse == "4")
            {
                return "The Return of the King";
            }
            else if (checkoutResponse == "5")
            {
                return "Everybody Poops";
            }
            else if (checkoutResponse == "6")
            {
                return "The Theif of Always";
            }
            else if (checkoutResponse == "7")
            {
                return "Go the F***to Sleep";
            }
            else if (checkoutResponse == "8")
            {
                return "Star Bellied Sneeches";
            }
            else if (checkoutResponse == "9")
            {
                return "The Dark Tower";
            }
            else if (checkoutResponse == "10")
            {
                return "Patriot Games";
            }
            else if (checkoutResponse == "11")
            {
                return "Rainbow Six";

            }
            else if (checkoutResponse == "12")
            {
                return "Red Rabbit";

            }
            else if (checkoutResponse == "13")
            {
                return "Pride and the Prejedice";
            }
            else if (checkoutResponse == "14")
            {
                return "OutLander";
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid selection.");
                Console.ResetColor();
                checkoutResponse = UserInput("Please select a book you would like to check out: ");
                return GetAuthor(checkoutResponse);
            }

        }



        public static void UserContinue()
        { 
            bool userContinue = true;
            while (userContinue)
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to continue? (y/n)");
                string userSelection = Console.ReadLine().ToLower();
                userContinue = false;

                switch (userSelection)
                {
                    case "y":
                        DisplayMenu();
                        break;
                    case "n":
                        Console.WriteLine("You get upset and yell - YOU DONT HAVE MOBY DICK!");
                        Console.WriteLine("The Librarian then has security escort you out");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please make a valid selection, Y or N");
                        userContinue = true;
                        break;
                }

            }

        }
    }
}
