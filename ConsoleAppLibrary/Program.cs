using ADOLibrary.ADORepository;
using ADOLibrary.Interface;
using ADOLibrary.Model;
using ConsoleAppLibrary.EditorHelper;
using System;

namespace ConsoleAppLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IRepositoryModel<Client> repositoryModelC = new ClientRepository();
            IRepositoryModel<Staff> repositoryModelS = new StaffRepository();
            IRepositoryModel<Author> repositoryModelA = new AuthorRepository();
            IRepositoryModel<Genre> repositoryModelG = new GenreRepository();
            IRepositoryModel<Hall> repositoryModelH = new HallRepository();
            IRepositoryModel<Book> repositoryModelB = new BookRepository();
            Console.WriteLine("Enter password to continue (12345):");
            string password = Console.ReadLine();
            int choice = -1;
            if (password == repositoryModelC.GetObj(6).Password)
            {
                while (choice !=0 )
                {
                    MenuConsole.ShowMainMenu();
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            {
                                bool operationShowAuthor = true;
                                do
                                {
                                    MenuConsole.ShowAuthorMenu();
                                    int ans = Convert.ToInt32(Console.ReadLine());
                                    switch (ans)
                                    {
                                        case 1:
                                            {
                                                SeeAllAuthor();
                                            }
                                            break;
                                        case 2:
                                            {
                                                AddAuthor();
                                            }
                                            break;
                                        case 3:
                                            {
                                                DeleteAuthor();
                                            }
                                            break;
                                        case 4:
                                            {
                                                GetAuthorById();
                                            }
                                            break;
                                        case 5:
                                            {
                                                operationShowAuthor = false;
                                            }
                                            break;
                                    }
                                } while (operationShowAuthor);
                            }
                            break;
                        case 2:
                            {
                                bool operationShowBook = true;
                                do
                                {
                                    MenuConsole.ShowBookMenu();
                                    int ans = Convert.ToInt32(Console.ReadLine());
                                    switch (ans)
                                    {
                                        case 1:
                                            {
                                                SeeAllBook();
                                            }
                                            break;
                                        case 2:
                                            {
                                                AddBook();
                                            }
                                            break;
                                        case 3:
                                            {
                                                DeleteBook();
                                            }
                                            break;
                                        case 4:
                                            {
                                                GetBookById();
                                            }
                                            break;
                                        case 5:
                                            {
                                                operationShowBook = false;
                                            }
                                            break;
                                    }
                                } while (operationShowBook);
                            }
                            break;
                        case 3:
                            {
                                bool operationShowClient = true;
                                do
                                {
                                    MenuConsole.ShowClientMenu();
                                    int ans = Convert.ToInt32(Console.ReadLine());
                                    switch (ans)
                                    {
                                        case 1:
                                            {
                                                SeeAllClient();
                                            }
                                            break;
                                        case 2:
                                            {
                                                AddClient();
                                            }
                                            break;
                                        case 3:
                                            {
                                                DeleteClient();
                                            }
                                            break;
                                        case 4:
                                            {
                                                GetClientById();
                                            }
                                            break;
                                        case 5:
                                            {
                                                operationShowClient = false;
                                            }
                                            break;
                                    }
                                } while (operationShowClient);
                            }
                            break;
                        case 4:
                            {
                                bool operationShowGenre= true;
                                do
                                {
                                    MenuConsole.ShowGenreMenu();
                                    int ans = Convert.ToInt32(Console.ReadLine());
                                    switch (ans)
                                    {
                                        case 1:
                                            {
                                                SeeAllGenre();
                                            }
                                            break;
                                        case 2:
                                            {
                                                AddGenre();
                                            }
                                            break;
                                        case 3:
                                            {
                                                DeleteGenre();
                                            }
                                            break;
                                        case 4:
                                            {
                                                GetGenreById();
                                            }
                                            break;
                                        case 5:
                                            {
                                                operationShowGenre = false;
                                            }
                                            break;
                                    }
                                } while (operationShowGenre);
                            }
                            break;
                        case 5:
                            {
                                bool operationShowHall = true;
                                do
                                {
                                    MenuConsole.ShowHallMenu();
                                    int ans = Convert.ToInt32(Console.ReadLine());
                                    switch (ans)
                                    {
                                        case 1:
                                            {
                                                SeeAllHall();
                                            }
                                            break;
                                        case 2:
                                            {
                                                AddHall();
                                            }
                                            break;
                                        case 3:
                                            {
                                                DeleteHall();
                                            }
                                            break;
                                        case 4:
                                            {
                                                GetHallById();
                                            }
                                            break;
                                        case 5:
                                            {
                                                operationShowHall = false;
                                            }
                                            break;
                                    }
                                } while (operationShowHall);
                            }
                            break;
                        case 6:
                            {
                                bool operationShowStaff = true;
                                do
                                {
                                    MenuConsole.ShowStaffMenu();
                                    int ans = Convert.ToInt32(Console.ReadLine());
                                    switch (ans)
                                    {
                                        case 1:
                                            {
                                                SeeAllStaff();
                                            }
                                            break;
                                        case 2:
                                            {
                                                AddStaff();
                                            }
                                            break;
                                        case 3:
                                            {
                                                DeleteStaff();
                                            }
                                            break;
                                        case 4:
                                            {
                                                GetStaffById();
                                            }
                                            break;
                                        case 5:
                                            {
                                                operationShowStaff = false;
                                            }
                                            break;
                                    }
                                } while (operationShowStaff);
                            }
                            break;
                        case 0:
                            break;
                           
                        default:
                            {
                                Console.WriteLine("Wrong choice!");
                            }
                            break;
                    }
                   
                }
            }
            else
            {
                Console.WriteLine("Error! Wrong password!");
            }

            /*
            Console.WriteLine("Client");
            foreach (var clTemp in repositoryModelC.GetProducts())
            {
                Console.WriteLine(clTemp.InformationSrt());
            }

            Console.WriteLine("Staff");
            foreach (var stTemp in repositoryModelS.GetProducts())
            {
                Console.WriteLine(stTemp.InformationStr());
            }

            Console.WriteLine("Author");
            foreach (var stTemp in repositoryModelA.GetProducts())
            {
                Console.WriteLine(stTemp.InformationStr());
            }

            Console.WriteLine("Book");
            foreach (var stTemp in repositoryModelB.GetProducts())
            {
                Console.WriteLine(stTemp.InformationStr());
            }

            Console.WriteLine("Genre");
            foreach (var stTemp in repositoryModelG.GetProducts())
            {
                Console.WriteLine(stTemp.InformationStr());
            }

            Console.WriteLine("Hall");
            foreach (var stTemp in repositoryModelH.GetProducts())
            {
                Console.WriteLine(stTemp.InformationStr());
            }
            */
        }

        private static void SeeAllAuthor()
        {
            IRepositoryModel<Author> repositoryModel = new AuthorRepository();
            foreach(var temp in repositoryModel.GetProducts())
            {
                Console.WriteLine($"Id: {temp.Id}\t Name:{temp.Firstname}\t Lastname:{temp.Lastname}");
            }
            Console.ReadLine();
        }

        private static void AddAuthor()
        {
            Console.Write("Enter author's first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter author's last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter author's date of birth (yyyy-mm-dd): ");
            DateTime dateOfBirth;

            while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
            {
                Console.Write("Invalid date format. Please enter date again (yyyy-mm-dd): ");
            }

            Author newAuthor = new Author
            {
                Firstname = firstName,
                Lastname = lastName,
                DateOfBirthd = dateOfBirth
            };

            IRepositoryModel<Author> authorRepository = new AuthorRepository();

            authorRepository.AddObj(newAuthor);
            Console.WriteLine("Author added successfully!");
            Console.ReadLine();
        }

        private static void DeleteAuthor()
        {
            IRepositoryModel<Author> repositoryModel = new AuthorRepository();
            Console.Write("Enter id to delete: ");
            int IdToDelete = Convert.ToInt32(Console.ReadLine());

            repositoryModel.DeleteObject(IdToDelete);
            Console.WriteLine($"Author with ID {IdToDelete} has been deleted successfully.");
            Console.ReadLine();
        }

        private static void GetAuthorById()
        {
            IRepositoryModel<Author> repositoryModel = new AuthorRepository();
            Console.Write("Enter id to get: ");
            int IdToGetAuthor=Convert.ToInt32(Console.ReadLine());
            Author temp_Author=repositoryModel.GetObj(IdToGetAuthor);
            Console.WriteLine($"ID: {temp_Author.Id}\t Firstname:{temp_Author.Firstname}\t Lastname:{temp_Author.Lastname}\t DateOfBirthd:{temp_Author.DateOfBirthd}");
            Console.ReadLine();

        }

        private static void SeeAllBook()
        {
            IRepositoryModel<Book> repositoryModel = new BookRepository();
            foreach (var temp in repositoryModel.GetProducts())
            {
                Console.WriteLine($"Id: {temp.Id}\t Name:{temp.Name}\t Price:{temp.Price}");
            }
            Console.ReadLine();
        }

        private static void AddBook()
        {
            Console.Write("Enter Author's ID:");
            int authorID=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Client's ID:");
            int clientID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Genre's ID:");
            int genreID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter price of book:");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter book's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter book's rating: ");
            int rating= Convert.ToInt32(Console.ReadLine());

            Book newBook= new Book
            {
                Name = name,
                Rating = rating,
                AuthorId= authorID,
                ClientId= clientID,
                GenreId= genreID,
                Price= price
            };

            IRepositoryModel<Book> bookRepository = new BookRepository();

            bookRepository.AddObj(newBook);
            Console.WriteLine("Book added successfully!");
            Console.ReadLine();
        }

        private static void DeleteBook()
        {
            IRepositoryModel<Book> repositoryModel = new BookRepository();
            Console.Write("Enter id to delete: ");
            int IdToDelete = Convert.ToInt32(Console.ReadLine());

            repositoryModel.DeleteObject(IdToDelete);
            Console.WriteLine($"Book with ID {IdToDelete} has been deleted successfully.");
            Console.ReadLine();
        }

        private static void GetBookById()
        {
            IRepositoryModel<Book> repositoryModel = new BookRepository();
            Console.Write("Enter id to get: ");
            int IdToGetBook= Convert.ToInt32(Console.ReadLine());
            Book temp = repositoryModel.GetObj(IdToGetBook);
            Console.WriteLine($"ID:{temp.Id}\t Name:{temp.Name}\t Price:{temp.Price}\t Rating:{temp.Rating}");
            Console.ReadLine();
        }

        private static void SeeAllClient()
        {
            IRepositoryModel<Client> repositoryModel = new ClientRepository();
            foreach (var temp in repositoryModel.GetProducts())
            {
                Console.WriteLine($"Id: {temp.Id}\t Name:{temp.Name}\t Lastname:{temp.Lastname}");
            }
            Console.ReadLine();
        }

        private static void AddClient()
        {
            Console.Write("Enter client's first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter client's last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter client's email: ");
            string email = Console.ReadLine();

            Console.Write("Enter client's password: ");
            string password = Console.ReadLine();

            Console.Write("Enter author's date of birth (yyyy-mm-dd): ");
            DateTime dateOfArriving;

            while (!DateTime.TryParse(Console.ReadLine(), out dateOfArriving))
            {
                Console.Write("Invalid date format. Please enter date again (yyyy-mm-dd): ");
            }

            Client newCLient= new Client
            {
                Name = firstName,
                Lastname = lastName,
                Email = email,
                Password= password,
                Arriving= dateOfArriving
            };

            IRepositoryModel<Client> clientRepository = new ClientRepository();

            clientRepository.AddObj(newCLient);
            Console.WriteLine("Client added successfully!");
            Console.ReadLine();
        }

        private static void DeleteClient()
        {
            IRepositoryModel<Client> repositoryModel = new ClientRepository();
            Console.Write("Enter id to delete: ");
            int IdToDelete = Convert.ToInt32(Console.ReadLine());

            repositoryModel.DeleteObject(IdToDelete);
            Console.WriteLine($"Client with ID {IdToDelete} has been deleted successfully.");
        }

        private static void GetClientById()
        {
            IRepositoryModel<Client> repositoryModel = new ClientRepository();
            Console.Write("Enter id to get: ");
            int IdToGetAuthor = Convert.ToInt32(Console.ReadLine());
            repositoryModel.GetObj(IdToGetAuthor);
            Client temp = repositoryModel.GetObj(IdToGetAuthor);
            Console.WriteLine($"ID:{temp.Id}\t First Name:{temp.Name}\t Last Name:{temp.Lastname}\t Email:{temp.Email}");
            Console.ReadLine();
        }

        private static void SeeAllGenre()
        {
            IRepositoryModel<Genre> repositoryModel = new GenreRepository();
            foreach (var temp in repositoryModel.GetProducts())
            {
                Console.WriteLine($"Id: {temp.Id}\t Type:{temp.Type}");
            }
            Console.ReadLine();
        }

        private static void AddGenre()
        {
            Console.Write("Enter Type of genre: ");
            string type = Console.ReadLine();

            Genre newGenre = new Genre
            {
                Type=type
            };

            IRepositoryModel<Genre> authorRepository = new GenreRepository();

            authorRepository.AddObj(newGenre);
            Console.WriteLine("Genre added successfully!");
            Console.ReadLine();
        }

        private static void DeleteGenre()
        {
            IRepositoryModel<Genre> repositoryModel = new GenreRepository();
            Console.Write("Enter id to delete: ");
            int IdToDelete = Convert.ToInt32(Console.ReadLine());

            repositoryModel.DeleteObject(IdToDelete);
            Console.WriteLine($"Genre with ID {IdToDelete} has been deleted successfully.");
            Console.ReadLine();
        }

        private static void GetGenreById()
        {
            IRepositoryModel<Genre> repositoryModel = new GenreRepository();
            Console.Write("Enter id to get: ");
            int IdToGetAuthor = Convert.ToInt32(Console.ReadLine());
            repositoryModel.GetObj(IdToGetAuthor);
            Genre temp = repositoryModel.GetObj(IdToGetAuthor);
            Console.WriteLine($"ID:{temp.Id}\t Type:{temp.Type}");
            Console.ReadLine();
        }

        private static void SeeAllHall()
        {
            IRepositoryModel<Hall> repositoryModel = new HallRepository();
            foreach (var temp in repositoryModel.GetProducts())
            {
                Console.WriteLine($"Id: {temp.Id}\t Name:{temp.Name}\t Lastname:{temp.PersonId}");
            }
            Console.ReadLine();
        }

        private static void AddHall()
        {
            Console.Write("Enter hall's name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter genreId for hall: ");
            int genreID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter personID(staff) for hall: ");
            int personID = Convert.ToInt32(Console.ReadLine());

            Hall newHall= new Hall
            {
                Name = firstName,
                PersonId = personID,
                GenreId = genreID
            };

            IRepositoryModel<Hall> hallRepository = new HallRepository();

            hallRepository.AddObj(newHall);
            Console.WriteLine("Hall added successfully!");
            Console.ReadLine();
        }

        private static void DeleteHall()
        {
            IRepositoryModel<Hall> repositoryModel = new HallRepository();
            Console.Write("Enter id to delete: ");
            int IdToDelete = Convert.ToInt32(Console.ReadLine());

            repositoryModel.DeleteObject(IdToDelete);
            Console.WriteLine($"Hall with ID {IdToDelete} has been deleted successfully.");
            Console.ReadLine();
        }

        private static void GetHallById()
        {
            IRepositoryModel<Hall> repositoryModel = new HallRepository();
            Console.Write("Enter id to get: ");
            int IdToGetAuthor = Convert.ToInt32(Console.ReadLine());
            Hall temp_hall=repositoryModel.GetObj(IdToGetAuthor);
            Console.WriteLine($"ID{temp_hall.Id}\t Name:{temp_hall.Name}\t PersonId:{temp_hall.PersonId}\t GenreId:{temp_hall.GenreId}");
            Console.ReadLine();
        }

        private static void SeeAllStaff()
        {
            IRepositoryModel<Staff> repositoryModel = new StaffRepository();
            //List<Staff> temp=repositoryModel.GetProducts();
            foreach (var item in repositoryModel.GetProducts())
            {
                Console.WriteLine($"ID: {item.Id}\t Name: {item.Name}\t Rating: {item.Rating}");
            }
            Console.ReadLine();
        }

        private static void AddStaff()
        {

            Console.Write("Enter staff name:");
            string name=Console.ReadLine();

            Console.Write("Enter staff rating:");
            int rating = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter staff role:");
            string role=Console.ReadLine();

            Staff staff = new Staff
            {
                Name=name,
                Rating=rating,
                Role=role
            };

            IRepositoryModel<Staff> repositoryModel = new StaffRepository();
            repositoryModel.AddObj(staff);
            Console.WriteLine("Staff added successfully!");
            Console.ReadLine();
        }

        private static void DeleteStaff()
        {
            IRepositoryModel<Staff> repositoryModel=new StaffRepository();

            Console.Write("Enter id to delete:");
            int IdToDeleteStaff = Convert.ToInt32(Console.ReadLine());
            repositoryModel.DeleteObject(IdToDeleteStaff);
            Console.WriteLine($"Staff with ID {IdToDeleteStaff} has been deleted successfully");
            Console.ReadLine();
        }

        private static void GetStaffById()
        {
            IRepositoryModel<Staff> repositoryModel = new StaffRepository();

            Console.Write("Enter id to get");
            int IdToGetAuthor = Convert.ToInt32(Console.ReadLine());
            Staff temp=repositoryModel.GetObj(IdToGetAuthor);
            Console.WriteLine($"ID:{temp.Id}\t Name:{temp.Name}\t Rating:{temp.Rating}");
            Console.ReadLine();
        }
    }
}
