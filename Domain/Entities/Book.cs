using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Book
{
    public int Id { get; set; }
    [Required,MaxLength(100)]
    public string Title { get; set; } 
    public decimal Price { get; set; }
    public int PageCount { get; set; }
  
   
public Book()
{
    
}
    public Book(int id, string title,decimal price, int pageCount)
    {
        Id = id;
        Title = title;
        Price = price;
        PageCount = pageCount;
     

    }
}