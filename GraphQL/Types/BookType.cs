public class BookType : ObjectType<Book>
{
    protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
    {
        descriptor.Description("Represents a book in the library.");

        descriptor
            .Field(b => b.Author)
            .ResolveWith<Resolvers>(b => b.GetAuthor(default!, default!))
            .UseDbContext<LibraryContext>()
            .Description("This is the author of the book.");
    }

    private class Resolvers
    {
        public Author GetAuthor(Book book, [ScopedService] LibraryContext context)
        {
            return context.Authors.FirstOrDefault(a => a.AuthorID == book.AuthorID);
        }
    }
}
