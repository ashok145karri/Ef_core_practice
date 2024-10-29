// See https://aka.ms/new-console-template for more information
using CodingWiki_DataAccess.Data;
using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using static System.Reflection.Metadata.BlobBuilder;

Console.WriteLine("Hello, World!");


/*using (ApplicationDbContext context = new ApplicationDbContext())
{
    context.Database.EnsureCreated();//it will find the connection string and check whether db is exists or not
    if(context.Database.GetPendingMigrations().Count() > 0)
    {

    context.Database.Migrate(); 
    }
}*/


//AddBook();
//GetAllBooks();

//GetBook();

//UpdateBook();
//DeleteBook();
/*
async void DeleteBook()
{
    using var context = new ApplicationDbContext();
    var books = await context.Fluent_Books.FindAsync(7);
    //we have tolistasync ,addasync
    context.Fluent_Books.Remove(books);

    //context.SaveChanges();
    await context.SaveChangesAsync();



}

void UpdateBook()
{
    using var context = new ApplicationDbContext();

    var books = context.Fluent_Books.Find(8);

    books.ISBN = "98480aa";
    //ef core will track everything 
    // we can update the multiple records using the where statement 
    context.SaveChanges();

}

void GetBook()
{

    using var context = new ApplicationDbContext();
    //major difference between the single and first is single selects top 2 and first selects top 1 so if we get two records while using the singleit will exception
    //same with firstordefault and singleordefault --> FirstOrDefault returns a first item of potentially multiple (or default if none exists).
    //-->SingleOrDefault assumes that there is a single item and returns it(or default if none exists). Multiple items are a violation of contract, an exception is thrown.
    //var books = context.Fluent_Books.Where(u=>u.Publisher_id == 3);
    //var books = context.Fluent_Books.Single(u=>u.Publisher_id == 3);
    //var book = context.Fluent_Books.FirstOrDefault(u=>u.Publisher_id == 3);
    //var book = context.Fluent_Books.Find(1);//with find we work with primary keys of a table
    // var books = context.Fluent_Books.Where(u=>u.ISBN.Contains("12")).ToList();
    // var books = context.Fluent_Books.Where(u => EF.Functions.Like(u.ISBN, "12%"));//.Max(u=>u.Price);//COUNT()

    //var books = context.Fluent_Books.OrderBy(u => u.ISBN).ThenByDescending(u=>u.Title); //first it  will order by isbn if we have the same isbn then it order by descending with title;
    var books = context.Fluent_Books.Skip(2).Take(2); //pagination

    //Console.WriteLine(books);
    //var book = context.Fluent_Books.Where(u=>u.Publisher_id == 3).First();
    // var book = context.Books.FirstOrDefault(); as we don't have the data in books table we can use the firstordefault to escape from the exception when there is no data.

    //Console.WriteLine(book.Title + "--" + book.ISBN);
    foreach (var book in books)
    {
        Console.WriteLine(book.Title + "--" + book.ISBN);
    }

    //DEFERRED EXECUTION
    //query will not excute if we write context.Books like that we have add either at the foreach while try to iterate it goes to db and excute
    //otherwise we can write the toList() or firstordefault and single
}


void GetAllBooks()
{
    using var context = new ApplicationDbContext();
    var books = context.Fluent_Books.ToList();

    foreach(var book in books)
    {
        Console.WriteLine(book.Title + "--"+book.ISBN);
    }


}


void AddBook()
{
    Fluent_Book book = new Fluent_Book() { Title = "HomeComing", ISBN = "6975a", Price = 89.0m, Publisher_id = 3 };//we cannot add the identity column 

    using var context = new ApplicationDbContext();

    var books = context.Fluent_Books.Add(book);//untill this point it will track that it has to add the data to db 

    context.SaveChanges(); //here only we able to add the data in the db

}

*/