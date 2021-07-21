
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryProject1
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine();

            //creating library file
            // text = text.PadLeft(35);
            var fileName = "library.txt";
            FileService.CreateFile(fileName);
            // creating library book database
            List<Book> bookList = new List<Book>();

            bookList.Add(new Book()
            {
                BookID = "1:",
                Title = "Amari and the Night Brothers",
                Author = "B.B. Alston",
                Status = true,
                DueDate = DateTime.Now
            }); ;
            bookList.Add(new Book()
            {
                BookID = "2:",
                Title = "Children of Blood and Bone",
                Author = "Tomi Adeyemi",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID = "3:",
                Title = "Children of Virtue and Vengeance",
                Author = "Tomi Adeyemi",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID = "4:",
                Title = "The Coldest Winter Ever",
                Author = "Sister Souljah",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID = "5:",
                Title = "No Disrespect",
                Author = "Sister Souljah",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID = "6:",
                Title = "Firekeeper's Daughter",
                Author = "Angeline Boulley",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID ="7:",
                Title = "Etiquette and Espionage",
                Author = "Gail Carriger",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID = "8:",
                Title = "Soulless",
                Author = "Gail Carriger",
                Status = false,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID ="9:",
                Title = "From Here to Timbuktu",
                Author = "Milton J. Davis",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID ="10:",
                Title = "Who Fears Death",
                Author = "Nnedi Okorafor",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID ="11:",
                Title = "Song of Blood and Stone",
                Author = "L. Penelope",
                Status = true,
                DueDate = DateTime.Now
            });
            bookList.Add(new Book()
            {
                BookID="12:",
                Title = "Obsidian and Blood",
                Author = "Aliette de Bodard",
                Status = true,
                DueDate = DateTime.Now
            });

            //FileService.SaveArrayAsCSV<Book>(bookList, fileName);
           //FileService.WriteBookToCSV(bookList, fileName);
            
            Console.WriteLine("welcome to the Library!");
            Console.WriteLine("Current Inventory:");
            Console.WriteLine("");
            Console.WriteLine(String.Format("{0, -3} | {1,-20} | {2, 5}", "BookID", "\t\tTitle", "\tAuthor"));
            foreach (var book in FileService.ConvertCSVToArray(fileName))
            {
                Console.WriteLine($"{book.BookID,5} \t {book.Title,-35} \t {book.Author,10}");
            }
            bookList = FileService.ConvertCSVToArray(fileName);
            var userAnswer = 0;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Select a number option:");
                Console.WriteLine("1: search by Author");
                Console.WriteLine("2: search by Title");
                Console.WriteLine("3: checkout book");
                Console.WriteLine("4: return book");
                Console.WriteLine("5: Add Book");
                Console.WriteLine("6: Display Library");
                Console.WriteLine("7: Quit");
                userAnswer = int.Parse(Console.ReadLine());
                if (userAnswer == 1)
                {
                    Console.WriteLine("author name:");
                    string userName = Console.ReadLine();
                    List<Book> Afiltered = FileService.SearchByType(userName, fileName, SearchTypeEnum.Author);
                    foreach (var book in Afiltered)
                    {
                        Console.WriteLine($"{book.Title,5} {book.Author,-35}");
                    }
                    Console.WriteLine();
                }
                else if (userAnswer == 2)
                {
                    Console.WriteLine("book title:");
                    string userName = Console.ReadLine();
                    List<Book> Afiltered = FileService.SearchByType(userName, fileName, SearchTypeEnum.Title);
                    foreach (var book in Afiltered)
                    {
                        Console.WriteLine($"{book.Title,5} \t {book.Author,-35}");
                    }
                    Console.WriteLine();

                }
                else if (userAnswer == 3)
                {
                    Console.WriteLine("check out a book, Title:");
                    string answer = Console.ReadLine();
                    FileService.CheckingOutBook(answer, bookList, fileName);


                }
                else if (userAnswer == 4)
                {
                    Console.WriteLine("return book");
                }
                else if (userAnswer == 5)
                {
                    Console.WriteLine("Add book");
                    Console.WriteLine("Title:");
                    string title = Console.ReadLine();
                    Console.WriteLine("Author:");
                    string author = Console.ReadLine();
                    Book newBook = new Book()
                    {
                        BookID = "13:",
                        Title = title,
                        Author = author,
                        Status = false,
                        DueDate = DateTime.Now
                    };

                    FileService.AddBook(newBook, fileName);
                    Console.WriteLine();

                }
                else if (userAnswer == 6)
                {
                    Console.WriteLine("welcome to the Library!");
                    Console.WriteLine("Current Inventory:");
                    Console.WriteLine("");
                    Console.WriteLine(String.Format("{0, -3} | {1,-20} | {2, 5}", "BookID", "\t\tTitle", "\tAuthor"));
                    foreach (var book in FileService.ConvertCSVToArray(fileName))
                    {
                        Console.WriteLine($"{book.BookID,5} \t {book.Title,-35} \t {book.Author,10}");
                    }
                }
                else
                {
                    Console.WriteLine("bye bye!!!!");
                }
            }
            while (userAnswer != 7);
            

        }


      
    }

}
