namespace BookExample;

class Program
{
    static void Main(string[] args)
    {
        // Book[] books = new Book[4];
        // books[0] = new Book() { Title = "Lord of the Flies", Author = "William Golding" };
        // books[1] = new Book() { Title = "The Hitchhiker's Guide to the Galaxy", Author = "Douglas Adams" };
        // books[2] = new Book() { Title = "Ready Player One", Author = "Ernest Cline" };
        // books[3] = new Book() { Title = "Foundation", Author = "Isaac Asimov" };
        //
        // for (int i = 0; i < books.Length; i++)
        // {
        //     Console.WriteLine(books[i].Title + " was written by " + books[i].Author);
        // }

        List<Book> books = new List<Book>();
        books.Add(new Book("1984", "George Orwell", "Second"));
        books.Add(new Book("Lord of the Flies","William Golding" ));
        books.Add(new Book("Ready Player One","Ernest Cline" ));
        books.Add(new Book("The Hitchhiker's Guide to the Galaxy", "Douglas Adams" ));
        books.Add(new Book("Ready Player Two","Ernest Cline" ));
        books.Add(new Book( "Foundation", "Isaac Asimov" ));
        books.Add(new Book("1984", "George Orwell", "Fourth"));
        books.Add(new Book("Ready Player Three","Ernest Cline" ));

        // Console.WriteLine("The first book " + books.First().GetInfo());
        
        foreach (Book book in books)
        {
            Console.WriteLine(book.GetInfo());
            Console.WriteLine($"It has {book.Pages}");
            Console.WriteLine(book.GetHashCode());

            Console.WriteLine(" --- ");
        }

        List<Book> BooksToRemove = new List<Book>();
        foreach (Book book in books)
        {
            if (book.Author.ToLower().Contains("cline"))
            {
                BooksToRemove.Add(book);
            }
        }

        foreach (Book book in BooksToRemove)
        {
            books.Remove(book);
        }
        
        BooksToRemove.Clear();

        int i = 0;

        // many moons later ...

        // Console.WriteLine("The last book " + books.Last().GetInfo());

        

        if (books.First().Equals(books.Last()))
        {
            Console.WriteLine("first and last are the same ...");
        }
        else
        {
            Console.WriteLine("first and last are NOT the same ...");
        }
    }
}

