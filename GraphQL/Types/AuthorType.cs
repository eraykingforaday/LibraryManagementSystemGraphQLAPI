public class AuthorType : ObjectType<Author>
{
    protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
    {
        descriptor.Description("Represents an author in the library.");

        descriptor
            .Field(a => a.Books)
            .ResolveWith<Resolvers>(a => a.GetBooks(default!, default!))
            .UseDbContext<LibraryContext>()
            .Description("This is the list of books by the author.");
    }

    private class Resolvers
    {
        public IEnumerable<Book> GetBooks(Author author, [ScopedService] LibraryContext context)
        {
            return context.Books.Where(b => b.AuthorID == author.AuthorID);
        }
    }
}
