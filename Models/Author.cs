public class Author
{
    public int AuthorID { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public ICollection<Book> Books { get; set; }
}
