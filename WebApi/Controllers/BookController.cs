using Domain.Entities;  
//using Domain.Dtos;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using AutoMapper;
using Domain.Dtos;
using Domain.Wrapper;


namespace WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class BookController:ControllerBase
{
    private readonly BookService _bookService;

    public BookController(BookService bookService)
    {
        _bookService = bookService;
    }
   [HttpGet("GetById")]
    public async Task<Response<List<BookDto>>> Get(int id)
     {
        return await _bookService.Get(id);
     }
    [HttpGet("GetDisPrice")]
    public async Task<Response<List<decimal>>> GetByPrice()
    {
        return await _bookService.GetByPrice();
    }
    [HttpGet("GetTake")]
    public async Task<Response<List<BookDto>>> GetByPrice(int skip,int take)
    {
        return await _bookService.GetByTake(skip,take);
    }
    
    [HttpGet("GetDisPricee")]
    public async Task<Response<List<BookDto>>> GetByPriceDis()
    {
        return await _bookService.GetByPriceDis();
    }
    
    [HttpGet("GetByCountId")]
    public async Task<Response<int>> GetByCountId()
    {
        return await _bookService.GetByCountId();
    }
    [HttpGet("GetByCountPrice")]
    public async Task<Response<List<BookPriceDto>>> GetPriceCount()
    {
        return await _bookService.GetPriceCount();
    }
    [HttpPost("AddEF")]
    public async Task<Response<string>> AddEf(AddBookDto model, int n)
    {
        if (ModelState.IsValid)
        {
            return await _bookService.AddEfData(model,n);
        }
        else
        {
            var errors = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage).ToList();
            return new Response<string>(HttpStatusCode.BadRequest, errors);
        }
    }
    [HttpPost("AddBulk")]
    public async Task<Response<string>> AddBulk(int n)
    {
        if (ModelState.IsValid)
        {
            return await _bookService.AddBulkData(n);
        }
        else
        {
            var errors = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage).ToList();
            return new Response<string>(HttpStatusCode.BadRequest, errors);
        }
    }
    
        
    
}