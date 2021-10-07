using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        //public List<BookModel> GetAllBooks()
        //{
        //    return _bookRepository.GetAllBooks();
        //}
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }
        public ViewResult GetBook(int id)
        {
            var dDetail= _bookRepository.GetBookById(id);
            return View(dDetail);
        }
        public List<BookModel> SearchBooks(string bookName,string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
