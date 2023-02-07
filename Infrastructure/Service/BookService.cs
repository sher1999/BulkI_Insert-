using  Domain.Dtos;
using Domain.Entities;
using Infrastructure.MapperProfiles;
using Infrastructure.SeedData;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System.Net;
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Wrapper;
using N.EntityFrameworkCore.Extensions;
using EFCore.BulkExtensions;
namespace Infrastructure.Service;


public class BookService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public BookService(DataContext context,IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<Response<List<BookPriceDto>>> GetPriceCount()
    {
        var test = await (from b in _context.Books
            group b by b.Price
            
            into g
            select new BookPriceDto
            {
             Price=g.Key,
                Counts = g.Count()
            }).ToListAsync();

        return new Response<List<BookPriceDto>>(test);
    }
    


    public async Task<Domain.Wrapper.Response<List<BookDto>>> Get(int id)
    {
        try
        {
            var result = await _context.Books.Where(b=>b.Id==id).ToListAsync();
            var mapped = _mapper.Map<List<BookDto>>(result);
            return new Domain.Wrapper.Response<List<BookDto>>(mapped);
        }
        catch (Exception e)
        {
            return new Domain.Wrapper.Response<List<BookDto>>(HttpStatusCode.InternalServerError,
                new List<string>() { e.Message });
        }
    } 
    public async Task<Domain.Wrapper.Response<List<decimal>>> GetByPrice()
     {
         try
        {
            var result =await _context.Books

                .Select(std => std.Price)

                .Distinct().ToListAsync();
            var mapped = _mapper.Map<List<decimal>>(result);
            return new Domain.Wrapper.Response<List<decimal>>(mapped);
        }
         catch (Exception e)
         {
             return new Domain.Wrapper.Response<List<decimal>>(HttpStatusCode.InternalServerError,
                 new List<string>() { e.Message });
        }
}
    public async Task<Domain.Wrapper.Response<List<BookDto>>> GetByPriceDis()
    {
        try
        {
            
            var result =await _context.Books
                .GroupBy(p => p.Price).Select(g => g.First()).ToListAsync();
            var mapped = _mapper.Map<List<BookDto>>(result);
            return new Domain.Wrapper.Response<List<BookDto>>(mapped);
        }
        catch (Exception e)
        {
            return new Domain.Wrapper.Response<List<BookDto>>(HttpStatusCode.InternalServerError,
                new List<string>() { e.Message });
        }
    }
    public async Task<Domain.Wrapper.Response<int>> GetByCountId()
    {
        try
        {

            var result =  _context.Books
                .GroupBy(p => p.Id).Count();
            
            return new Domain.Wrapper.Response<int>(result);
        }
        catch (Exception e)
        {
            return new Domain.Wrapper.Response<int>(HttpStatusCode.InternalServerError,
                new List<string>() { e.Message });
        }
    }
    public async Task<Domain.Wrapper.Response<List<BookDto>>> GetByTake(int s,int t)
    {
        try
        {

            var result = await (from b in _context.Books
                select b).Skip(s).Take(t).ToListAsync();
                
            var mapped = _mapper.Map<List<BookDto>>(result);
            return new Domain.Wrapper.Response<List<BookDto>>(mapped);
        }
        catch (Exception e)
        {
            return new Domain.Wrapper.Response<List<BookDto>>(HttpStatusCode.InternalServerError,
                new List<string>() { e.Message });
        }
    }
    public async Task<Domain.Wrapper.Response<string>> AddEfData(AddBookDto model,int n){
       
    
       try
       {
           var sw = new Stopwatch();
           sw.Start();
        for (int i = 0; i < n; i++)
        {   
            var mapped = _mapper.Map<Book>(model);
            await _context.Books.AddAsync(mapped);
            await _context.SaveChangesAsync();
        }
           
        sw.Stop();

            return new Domain.Wrapper.Response<string>($"Adding Ef Time :   {sw.ElapsedMilliseconds}");


       }
        catch (Exception e)
        {
            return  new Domain.Wrapper.Response<string>(HttpStatusCode.InternalServerError,new List<string>(){e.Message});
        }
     
       
    }
    public async Task<Domain.Wrapper.Response<string>> AddBulkData(int n)
    {

        var rnd = new Random();
        var books = new List<Book>();
        try
        {
            var sw = new Stopwatch();
            sw.Start();
            
            for (int i = 0; i < n; i++)
            {
                var book = new Book()
                {

                    Title = $"Test {i}",
                    Price = rnd.Next(100, 1000),
                    PageCount = rnd.Next(100, 2000),
                };
              books.Add(book);
             
            }

          await  _context.BulkInsertAsync(books);
            sw.Stop();

            return new Domain.Wrapper.Response<string>($"Adding Ef Time :   {sw.ElapsedMilliseconds}");


        }
        catch (Exception e)
        {
            return  new Domain.Wrapper.Response<string>(HttpStatusCode.InternalServerError,new List<string>(){e.Message});
        }
     
       
    }

}