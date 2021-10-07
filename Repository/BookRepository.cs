using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            BookModel book= DataSource().Where(x => x.Id == id).FirstOrDefault();
            return book;
        }
        public List<BookModel> SearchBook(string Title,String AuthorName)
        {
            return DataSource().Where(x => x.Title.Contains(Title) || x.Author.Contains(AuthorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="Jalees",Description="This is the description for MVC book",path="netMVc.jpg",Category="Programming",Language="English",TotPages=134},
                new BookModel(){Id=2,Title="Csharp",Author="Rahul",Description="This is the description for Csharp book",path="2.png",Category="DotNetFramework",Language="Tamil",TotPages=547},
                new BookModel(){Id=3,Title="Java",Author="Bilagate",Description="This is the description for Java book",path="tjava.png",Category="javaProgramming",Language="Malayalam",TotPages=747},
                new BookModel(){Id=4,Title="Python",Author="Suhel",Description="This is the description for Python book",path="tpython.png",Category="PythonProgramming",Language="Hindi",TotPages=800},
                new BookModel(){Id=5,Title="Angular",Author="Habeeb",Description="This is the description for Angular book",path="1.png",Category="AngularProgramming",Language="Arabic",TotPages=457},
                new BookModel(){Id=6,Title="react",Author="gannicus",Description="This is the description for React book",path="tphp.png",Category="AzureProgramming",Language="Urdu",TotPages=102},
                new BookModel(){Id=7,Title="Azure DevOps",Author="Spartacus",Description="This is the description for Azure DevOps",path="6.png",Category="reactProgramming",Language="French",TotPages=187},
                new BookModel(){Id=8,Title="AWS",Author="Ishaq",Description="This is the description for Aws",path="aws.png",Category="AWSProgramming",Language="Germany",TotPages=134},
                new BookModel(){Id=9,Title="Jquery",Author="Shakir",Description="This is the description for Jquery",path="tcplus.png",Category="JqueryProgramming",Language="Telungu",TotPages=989},

            };
        }
          
    }
}
