public class Query
{
    public IQueryable<Book> GetBooks([Service] LibraryContext context) => context.Books;
    public IQueryable<Author> GetAuthors([Service] LibraryContext context) => context.Authors;
}
