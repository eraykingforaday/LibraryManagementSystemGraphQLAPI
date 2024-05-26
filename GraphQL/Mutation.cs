public class Mutation
{
    public async Task<Book> AddBookAsync(Book book, [Service] LibraryContext context)
    {
        context.Books.Add(book);
        await context.SaveChangesAsync();
        return book;
    }

    public async Task<Author> AddAuthorAsync(Author author, [Service] LibraryContext context)
    {
        context.Authors.Add(author);
        await context.SaveChangesAsync();
        return author;
    }
}
