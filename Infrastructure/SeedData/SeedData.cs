using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.SeedData;

public static  class SeedData
{
    public static void Seed(DataContext context)
    {
    //     if (context.Subjects.Any())
    //         return;
        
    //     var subjects = new List<Subject>()
    //     {
    //         new (1, "Math", "Mathematics"),
    //         new(2, "Physics", "Physics"),
    //         new(3, "Chemistry", "Chemistry"),
    //         new(4, "Biology", "Biology"),
    //         new(5, "English", "English"),
    //     };
        
    //     var authors = new List<Author>()
    //     {
    //       new (1, "John", "Doe", "John Doe is a famous author", "www.johndoe.com"),
    //         new (2, "Jane", "Doe", "Jane Doe is a famous author", "www.janedoe.com"),
    //         new (3, "John", "Smith", "John Smith is a famous author", "www.johnsmith.com"),
    //         new (4, "Jane", "Smith", "Jane Smith is a famous author", "www.janesmith.com"),
    //         new (5, "John", "Doe", "John Doe is a famous author", "www.johndoe.com"),
    //         new (6, "Jane", "Doe", "Jane Doe is a famous author", "www.janedoe.com"),
    //         new (7, "John", "Smith", "John Smith is a famous author", "www.johnsmith.com"),
    //     };
        
    //     var books = new List<Book>()
    //     {
    //         new Book(1, "Mathematics", DateTime.UtcNow.AddYears(-10), 44, 55, "test", "famous book", "no for now", 1, 1),
    //         new Book(2, "Physics", DateTime.UtcNow.AddYears(-10), 44, 55, "test", "famous book", "no for now", 2, 2),
    //         new Book(3, "Chemistry", DateTime.UtcNow.AddYears(-10), 44, 55, "test", "famous book", "no for now", 2, 3),
    //         new Book(4, "Biology", DateTime.UtcNow.AddYears(-10), 44, 55, "test", "famous book", "no for now", 3, 4),
    //         new Book(5, "English", DateTime.UtcNow.AddYears(-10), 44, 55, "test", "famous book", "no for now", 3, 5),
    //         new Book(6, "Mathematics", DateTime.UtcNow.AddYears(-10), 44, 55, "test", "famous book", "no for now", 1, 1),
    //     };

    //     var bookAuthors = new List<BookAuthor>()
    //     {
    //         new BookAuthor(1,1),
    //         new BookAuthor(1,2),
    //         new BookAuthor(2,3),
    //         new BookAuthor(2,4),
    //         new BookAuthor(3,5),
    //     };
        
    //     var publishers = new List<Publisher>()
    //     {
    //         new Publisher(1, "Publisher 1", "Publisher 1", "www.publisher1.com"),
    //         new Publisher(2, "Publisher 2", "Publisher 2", "www.publisher2.com"),
    //         new Publisher(3, "Publisher 3", "Publisher 3", "www.publisher3.com"),
    //         new Publisher(4, "Publisher 4", "Publisher 4", "www.publisher4.com"),
    //         new Publisher(5, "Publisher 5", "Publisher 5", "www.publisher5.com"),
    //     };

    //     var users = new List<User>()
    //     {
    //         new User(1, "test@gmail.com", "12345", "John", "Doe"),
    //         new User(2, "test2@gmail.com", "12345", "Jane", "Doe"),
    //         new User(3, "test3@gmail.com", "12345", "John", "Smith"),
    //         new User(4, "test5@gmail.com", "12345", "Array", "Smith"),
    //     };



    //     var reviews = new List<Review>()
    //     {
    //         new Review(1, "Review 1", "this is test Coomment", 4, 1, 1),
    //         new Review(2, "Review 2", "this is test Coomment", 4, 3, 2),
    //         new Review(3, "Review 3", "this is test Coomment", 5, 2, 3),
    //         new Review(4, "Review 4", "this is test Coomment", 6, 2, 4),
    //     };

    //     context.Authors.AddRange(authors);
    //     context.Books.AddRange(books);
    //     context.AuthorBooks.AddRange(bookAuthors);
    //     context.Publishers.AddRange(publishers);
    //     context.Subjects.AddRange(subjects);
    //     context.Users.AddRange(users);
    //     context.Reviews.AddRange(reviews);
    //     context.SaveChanges();
        
    // }
}}