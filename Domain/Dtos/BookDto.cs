using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos;

public class BookDto
{
    
   public int Id { get; set; }
    [Required,MaxLength(100)]
    public string Title { get; set; } 
    public decimal Price { get; set; }
    public int PageCount { get; set; }
  
   
public BookDto()
{
    
}
    public BookDto(int id, string title,decimal price, int pageCount)
    {
        Id = id;
        Title = title;
        Price = price;
        PageCount = pageCount;
     

    }
}
