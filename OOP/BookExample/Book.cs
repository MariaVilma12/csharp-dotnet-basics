namespace BookExample;

public class Book
{
    public String Title;
    public String Author;
    public String Edition = "unknown";
    public int Pages;

    /// <summary>
    /// The book class ...
    /// </summary>
    /// <param name="title">The book's Title</param>
    /// <param name="author">Thew book's Author</param>
    public Book(string title, string author):this()
    {
        Title = title;
        Author = author;
    }

    public Book(string title, string author, string edition):this(title, author)
    {
        Edition = edition;
    }

    public Book()
    {
        Random random = new Random();
        Pages = random.Next(100, 1000);   
    }

    public string GetInfo()
    {
        return  "'" + this.Title + "' was written by " + this.Author;
    }

    public override string ToString()
    {
        return Title + ":" + Author;
    }

    public override bool Equals(object? obj)
    {
        Book other = (Book)obj;

        return ((this.Author == other.Author) &&
                (this.Title == other.Title) &&
                (this.Edition == other.Edition))
            ;
    }

    
}